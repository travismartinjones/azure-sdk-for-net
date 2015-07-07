namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using System.Linq.Expressions;
    using Microsoft.Azure;
    using Models;

    public static partial class VirtualMachinesOperationsExtensions
    {
            /// <summary>
            /// Captures the VM by copying VirtualHardDisks of the VM and outputs a
            /// template that can be used to create similar VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Capture Virtual Machine operation.
            /// </param>
            public static ComputeLongRunningOperationResult Capture(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachineCaptureParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).CaptureAsync(resourceGroupName, vmName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Captures the VM by copying VirtualHardDisks of the VM and outputs a
            /// template that can be used to create similar VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Capture Virtual Machine operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ComputeLongRunningOperationResult> CaptureAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachineCaptureParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ComputeLongRunningOperationResult> result = await operations.CaptureWithHttpMessagesAsync(resourceGroupName, vmName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Captures the VM by copying VirtualHardDisks of the VM and outputs a
            /// template that can be used to create similar VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Capture Virtual Machine operation.
            /// </param>
            public static ComputeLongRunningOperationResult BeginCapture(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachineCaptureParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).BeginCaptureAsync(resourceGroupName, vmName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Captures the VM by copying VirtualHardDisks of the VM and outputs a
            /// template that can be used to create similar VMs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Capture Virtual Machine operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ComputeLongRunningOperationResult> BeginCaptureAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachineCaptureParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ComputeLongRunningOperationResult> result = await operations.BeginCaptureWithHttpMessagesAsync(resourceGroupName, vmName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The operation to create or update a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Virtual Machine operation.
            /// </param>
            public static VirtualMachine CreateOrUpdate(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachine parameters)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).CreateOrUpdateAsync(resourceGroupName, vmName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Virtual Machine operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachine> CreateOrUpdateAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachine parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachine> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The operation to create or update a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Virtual Machine operation.
            /// </param>
            public static VirtualMachine BeginCreateOrUpdate(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachine parameters)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, vmName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Virtual Machine operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachine> BeginCreateOrUpdateAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, VirtualMachine parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachine> result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, vmName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The operation to delete a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void Delete(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).DeleteAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to delete a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void BeginDelete(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).BeginDeleteAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to get a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// Name of the property to expand. Allowed value is null or 'instanceView'.
            /// </param>
            public static VirtualMachine Get(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).GetAsync(resourceGroupName, vmName, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='expand'>
            /// Name of the property to expand. Allowed value is null or 'instanceView'.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachine> GetAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachine> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmName, expand, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Shuts down the Virtual Machine and releases the compute resources. You are
            /// not billed for the compute resources that this Virtual Machine uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void Deallocate(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).DeallocateAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Shuts down the Virtual Machine and releases the compute resources. You are
            /// not billed for the compute resources that this Virtual Machine uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeallocateAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeallocateWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Shuts down the Virtual Machine and releases the compute resources. You are
            /// not billed for the compute resources that this Virtual Machine uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void BeginDeallocate(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).BeginDeallocateAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Shuts down the Virtual Machine and releases the compute resources. You are
            /// not billed for the compute resources that this Virtual Machine uses.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginDeallocateAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeallocateWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Sets the state of the VM as Generalized.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void Generalize(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).GeneralizeAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the state of the VM as Generalized.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GeneralizeAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GeneralizeWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to list virtual machines under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static VirtualMachineListResult List(this IVirtualMachinesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).ListAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to list virtual machines under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineListResult> ListAsync( this IVirtualMachinesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineListResult> result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets the list of Virtual Machines in the subscription. Use nextLink
            /// property in the response to get the next page of Virtual Machines. Do
            /// this till nextLink is not null to fetch all the Virtual Machines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static VirtualMachineListResult ListAll(this IVirtualMachinesOperations operations)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).ListAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Virtual Machines in the subscription. Use nextLink
            /// property in the response to get the next page of Virtual Machines. Do
            /// this till nextLink is not null to fetch all the Virtual Machines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineListResult> ListAllAsync( this IVirtualMachinesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineListResult> result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Lists virtual-machine-sizes available to be used for a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static VirtualMachineSizeListResult ListAvailableSizes(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).ListAvailableSizesAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists virtual-machine-sizes available to be used for a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineSizeListResult> ListAvailableSizesAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineSizeListResult> result = await operations.ListAvailableSizesWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void PowerOff(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).PowerOffAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PowerOffAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PowerOffWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void BeginPowerOff(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).BeginPowerOffAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to power off (stop) a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginPowerOffAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginPowerOffWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to restart a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void Restart(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).RestartAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to restart a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task RestartAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.RestartWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to restart a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void BeginRestart(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).BeginRestartAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to restart a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginRestartAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to start a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void Start(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).StartAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to start a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task StartAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StartWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to start a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            public static void BeginStart(this IVirtualMachinesOperations operations, string resourceGroupName, string vmName)
            {
                Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).BeginStartAsync(resourceGroupName, vmName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to start a virtual machine.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='vmName'>
            /// The name of the virtual machine.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task BeginStartAsync( this IVirtualMachinesOperations operations, string resourceGroupName, string vmName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, vmName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The operation to list virtual machines under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static VirtualMachineListResult ListNext(this IVirtualMachinesOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).ListNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to list virtual machines under a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineListResult> ListNextAsync( this IVirtualMachinesOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineListResult> result = await operations.ListNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets the list of Virtual Machines in the subscription. Use nextLink
            /// property in the response to get the next page of Virtual Machines. Do
            /// this till nextLink is not null to fetch all the Virtual Machines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            public static VirtualMachineListResult ListAllNext(this IVirtualMachinesOperations operations, string nextLink)
            {
                return Task.Factory.StartNew(s => ((IVirtualMachinesOperations)s).ListAllNextAsync(nextLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of Virtual Machines in the subscription. Use nextLink
            /// property in the response to get the next page of Virtual Machines. Do
            /// this till nextLink is not null to fetch all the Virtual Machines.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='nextLink'>
            /// NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<VirtualMachineListResult> ListAllNextAsync( this IVirtualMachinesOperations operations, string nextLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<VirtualMachineListResult> result = await operations.ListAllNextWithHttpMessagesAsync(nextLink, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
