using System;
using System.Configuration;
using System.Linq.Expressions;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ServiceProvider.Provider
{
    public abstract class ProviderBase<TContract> 
        where TContract : class
    {
        static private TContract _channel;

        static ProviderBase()
        {
            InitialiseChannel();
        }

        private static void InitialiseChannel()
        {
            var binding = new NetTcpBinding("TejasBinding");

            //var name = ConfigurationManager.AppSettings[typeof (TContract).FullName];
            var endpointAddress = new EndpointAddress("http://localhost:62220/TejasSevice");

            var factory = new ChannelFactory<TContract>(binding, endpointAddress);

            foreach (var op in factory.Endpoint.Contract.Operations) 
            { 
                var dataContractBehavior = op.Behaviors.Find<DataContractSerializerOperationBehavior>(); 
                if (dataContractBehavior != null) 
                { 
                    dataContractBehavior.MaxItemsInObjectGraph = 2147483647; 
                } 
            } 

            _channel = factory.CreateChannel();            
        }

        /// <summary>
        /// Invokes a method on TContract.
        /// </summary>
        /// <typeparam name="TResult">The return type of 'method'</typeparam>
        /// <param name="method">The method on TContract to be invoked</param>
        /// <returns>The result of 'method'</returns>
        protected TResult Invoke<TResult>(Expression<Func<TContract, TResult>> method)
        {
            var attempt = 1;

            while (attempt < 3)
            {
                try
                {
                    return method.Compile().Invoke(_channel);
                }
                catch (FaultException)
                {
                    throw;
                }
                catch (CommunicationException)
                {
                    attempt++;

                    if (attempt > 2)
                        throw;

                    InitialiseChannel();
                }
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Invokes a method on TContract.
        /// </summary>
        /// <param name="method">The method on TContract to be invoked</param>
        protected void Invoke(Expression<Action<TContract>> method)
        {
            var attempt = 1;

            while (attempt < 3)
            {
                try
                {
                    method.Compile().Invoke(_channel);
                    return;
                }
                catch (FaultException)
                {
                    throw;
                }
                catch (CommunicationException)
                {
                    attempt++;

                    if (attempt > 2)
                        throw;

                    InitialiseChannel();
                }
            }

        }
    }
}
