using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using SIPServer.Services.Contracts;
using SIPServer.Services.Implementations;

namespace SIPServer.Hosting
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            #region CallService
            ServiceHost callServiceHost = new ServiceHost(typeof(CallServiceImplementation));
            callServiceHost.UnknownMessageReceived += new EventHandler<UnknownMessageReceivedEventArgs>(callServiceHost_UnknownMessageReceived);
            callServiceHost.Faulted += new EventHandler(callServiceHost_Faulted);
            NetTcpBinding callServiceBinding = new NetTcpBinding
            {
                ListenBacklog = 50,
                MaxBufferPoolSize = long.MaxValue,
                MaxBufferSize = int.MaxValue,
                MaxConnections = 1000,
                MaxReceivedMessageSize = (long)int.MaxValue,
                TransactionFlow = true
            };

            callServiceBinding.Security.Mode = SecurityMode.Transport;
            callServiceBinding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            callServiceBinding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;

            callServiceHost.AddServiceEndpoint(typeof(ICallService), callServiceBinding, "net.tcp://192.168.0.9:5262/ICallService");

            callServiceHost.Description.Behaviors.RemoveAll<ServiceMetadataBehavior>();
            callServiceHost.Description.Behaviors.Add(new ServiceMetadataBehavior()
            {
                HttpGetUrl = new Uri("http://192.168.0.9:5263/ICallServiceDescription"),
                HttpGetEnabled = true
            });

            callServiceHost.Description.Behaviors.RemoveAll<ServiceThrottlingBehavior>();
            callServiceHost.Description.Behaviors.Add(new ServiceThrottlingBehavior()
            {
                MaxConcurrentCalls = 50,
                MaxConcurrentInstances = 25,
                MaxConcurrentSessions = 50
            });

            callServiceHost.Description.Behaviors.RemoveAll<ServiceSecurityAuditBehavior>();
            callServiceHost.Description.Behaviors.Add(new ServiceSecurityAuditBehavior()
            {
                AuditLogLocation = AuditLogLocation.Application,
                MessageAuthenticationAuditLevel = AuditLevel.Failure,
                ServiceAuthorizationAuditLevel = AuditLevel.Failure,
                SuppressAuditFailure = true
            });
            #endregion

            #region ManagementService
            ServiceHost managementServiceHost = new ServiceHost(typeof(ManagementServiceImplementation));
            NetNamedPipeBinding managementServiceBinding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.Transport)
            {
                MaxBufferPoolSize = long.MaxValue,
                MaxBufferSize = int.MaxValue,
                MaxReceivedMessageSize = (long)int.MaxValue
            };
            managementServiceBinding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;

            managementServiceHost.AddServiceEndpoint(typeof(IManagementServiceContract), managementServiceBinding, "net.pipe://192.168.0.9/IManagementService");

            managementServiceHost.Description.Behaviors.RemoveAll<ServiceMetadataBehavior>();
            managementServiceHost.Description.Behaviors.Add(new ServiceMetadataBehavior()
            {
                HttpGetUrl = new Uri("http://192.168.0.9:8890/IManagementServiceDescription"),
                HttpGetEnabled = true
            });

            managementServiceHost.Description.Behaviors.RemoveAll<ServiceThrottlingBehavior>();
            managementServiceHost.Description.Behaviors.Add(new ServiceThrottlingBehavior()
            {
                MaxConcurrentCalls = 50,
                MaxConcurrentInstances = 25,
                MaxConcurrentSessions = 50
            });

            managementServiceHost.Description.Behaviors.RemoveAll<ServiceSecurityAuditBehavior>();
            managementServiceHost.Description.Behaviors.Add(new ServiceSecurityAuditBehavior()
            {
                AuditLogLocation = AuditLogLocation.Application,
                MessageAuthenticationAuditLevel = AuditLevel.Failure,
                ServiceAuthorizationAuditLevel = AuditLevel.Failure,
                SuppressAuditFailure = true
            }); 
            #endregion

            try
            {
                callServiceHost.Open();
                Console.WriteLine("CallService ist running.");
                managementServiceHost.Open();
                Console.WriteLine("ManagementService ist running.");
                Console.WriteLine("Enter to finish...");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            callServiceHost.Close();
        }

        static void callServiceHost_UnknownMessageReceived(object sender, UnknownMessageReceivedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }

        static void callServiceHost_Faulted(object sender, EventArgs e)
        {
        }
    }
}