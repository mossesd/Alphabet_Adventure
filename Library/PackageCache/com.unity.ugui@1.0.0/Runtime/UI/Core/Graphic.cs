kPhysicalDeviceFloatControlsPropertiesKHR();
    ~safe_VkPhysicalDeviceFloatControlsPropertiesKHR();
    void initialize(const VkPhysicalDeviceFloatControlsPropertiesKHR* in_struct);
    void initialize(const safe_VkPhysicalDeviceFloatControlsPropertiesKHR* src);
    VkPhysicalDeviceFloatControlsPropertiesKHR *ptr() { return reinterpret_cast<VkPhysicalDeviceFloatControlsPropertiesKHR *>(this); }
    VkPhysicalDeviceFloatControlsPropertiesKHR const *ptr() const { return reinterpret_cast<VkPhysicalDeviceFloatControlsPropertiesKHR const *>(this); }
};

struct safe_VkSubpassDescriptionDepthStencilResolveKHR {
    VkStructureType sType;
    const void* pNext;
    VkResolveModeFlagBitsKHR depthResolveMode;
    VkResolveModeFlagBitsKHR stencilResolveMode;
    safe_VkAttachmentReference2KHR* pDepthStencilResolveAttachment;
    safe_VkSubpassDescriptionDepthStencilResolveKHR(const VkSubpassDescriptionDepthStencilResolveKHR* in_struct);
    safe_VkSubpassDescriptionDepthStencilResolveKHR(const safe_VkSubpassDescriptionDepthStencilResolveKHR& src);
    safe_VkSubpassDescriptionDepthStencilResolveKHR& operator=(const safe_VkSubpassDescriptionDepthStencilResolveKHR& src);
    safe_VkSubpassDescriptionDepthStencilResolveKHR();
    ~safe_VkSubpassDescriptionDepthStencilResolveKHR();
    void initialize(const VkSubpassDescriptionDepthStencilResolveKHR* in_struct);
    void initialize(const safe_VkSubpassDescriptionDepthStencilResolveKHR* src);
    VkSubpassDescriptionDepthStencilResolveKHR *ptr() { return reinterpret_cast<VkSubpassDescriptionDepthStencilResolveKHR *>(this); }
    VkSubpassDescriptionDepthStencilResolveKHR const *ptr() const { return reinterpret_cast<VkSubpassDescriptionDepthStencilResolveKHR const *>(this); }
};

struct safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR {
    VkStructureType sType;
    void* pNext;
    VkResolveModeFlagsKHR supportedDepthResolveModes;
    VkResolveModeFlagsKHR supportedStencilResolveModes;
    VkBool32 independentResolveNone;
    VkBool32 independentResolve;
    safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR(const VkPhysicalDeviceDepthStencilResolvePropertiesKHR* in_struct);
    safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR(const safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR& src);
    safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR& operator=(const safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR& src);
    safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR();
    ~safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR();
    void initialize(const VkPhysicalDeviceDepthStencilResolvePropertiesKHR* in_struct);
    void initialize(const safe_VkPhysicalDeviceDepthStencilResolvePropertiesKHR* src);
    VkPhysicalDeviceDepthStencilResolvePropertiesKHR *ptr() { return reinterpret_cast<VkPhysicalDeviceDepthStencilResolvePropertiesKHR *>(this); }
    VkPhysicalDeviceDepthStencilResolvePropertiesKHR const *ptr() const { return reinterpret_cast<VkPhysicalDeviceDepthStencilResolvePropertiesKHR const *>(this); }
};

struct safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR {
    VkStructureType sType;
    void* pNext;
    VkBool32 vulkanMemoryModel;
    VkBool32 vulkanMemoryModelDeviceScope;
    VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
    safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR(const VkPhysicalDeviceVulkanMemoryModelFeaturesKHR* in_struct);
    safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR(const safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR& src);
    safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR& operator=(const safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR& src);
    safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR();
    ~safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR();
    void initialize(const VkPhysicalDeviceVulkanMemoryModelFeaturesKHR* in_struct);
    void initialize(const safe_VkPhysicalDeviceVulkanMemoryModelFeaturesKHR* src);
    VkPhysicalDeviceVulkanMemoryModelFeaturesKHR *ptr() { return reinterpret_cast<VkPhysicalDeviceVulkanMemoryModelFeaturesKHR *>(this); }
    VkPhysicalDeviceVulkanMemoryModelFeaturesKHR const *ptr() const { return reinterpret_cast<VkPhysicalDeviceVulkanMemoryModelFeaturesKHR const *>(this); }
};

struct safe_VkSurfaceProtectedCapabilitiesKHR {
    VkStructureType sType;
    const void* pNext;
    VkBool32 supportsProtected;
    safe_VkSurfaceProtectedCapabilitiesKHR(const VkSurfaceProtectedCapabilitiesKHR* in_struct);
    safe_VkSurfaceProtectedCapabilitiesKHR(const safe_VkSurfaceProtectedCapabilitiesKHR& src);
    safe_VkSurfaceProtectedCapabilitiesKHR& operator=(const safe_VkSurfaceProtectedCapabilitiesKHR& src);
    safe_VkSurfaceProtectedCapabilitiesKHR();
    ~safe_VkSurfaceProtectedCapabilitiesKHR();
    void initialize(const VkSurfaceProtectedCapabilitiesKHR* in_struct);
    void initialize(const safe_VkSurfaceProtectedCapabilitiesKHR* src);
    VkSurfaceProtectedCapabilitiesKHR *ptr() { return reinterpret_cast<VkSurfaceProtectedCapabilitiesKHR *>(this); }
    VkSurfaceProtectedCapabilitiesKHR const *ptr() const { return reinterpret_cast<VkSurfaceProtectedCapabilitiesKHR const *>(this); }
};

struct safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR {
    VkStructureType sType;
    void* pNext;
    VkBool32 uniformBufferStandardLayout;
    safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR(const VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR* in_struct);
    safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR(const safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR& src);
    safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR& operator=(const safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR& src);
    safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR();
    ~safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR();
    void initialize(const VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR* in_struct);
    void initialize(const safe_VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR* src);
    VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR *ptr() { return reinterpret_cast<VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR *>(this); }
    VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR const *ptr() const { return reinterpret_cast<VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR const *>(this); }
};

struct safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR {
    VkStructureType sType;
    void* pNext;
    VkBool32 pipelineExecutableInfo;
    safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR(const VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR* in_struct);
    safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR(const safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR& src);
    safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR& operator=(const safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR& src);
    safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR();
    ~safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR();
    void initialize(const VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR* in_struct);
    void initialize(const safe_VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR* src);
    VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR *ptr() { return reinterpret_cast<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR *>(this); }
    VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR const *ptr() const { return reinterpret_cast<VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR const *>(this); }
};

struct safe_VkPipelineInfoKHR {
    VkStructureType sType;
    const void* pNext;
    VkPipeline pipeline;
    safe_VkPipelineInfoKHR(const VkPipelineInfoKHR* in_struct);
    safe_VkPipelineInfoKHR(const safe_VkPipelineInfoKHR& src);
    safe_VkPipelineInfoKHR& operator=(const safe_VkPipelineInfoKHR& src);
    safe_VkPipelineInfoKHR();
    ~safe_VkPipelineInfoKHR();
    void initialize(const VkPipelineInfoKHR* in_struct);
    void initialize(const safe_VkPipelineInfoKHR* src);
    VkPipelineInfoKHR *ptr() { return reinterpret_cast<VkPipelineInfoKHR *>(this); }
    VkPipelineInfoKHR const *ptr() const { return reinterpret_cast<VkPipelineInfoKHR const *>(this); }
};

struct safe_VkPipelineExecutablePropertiesKHR {
    VkStructureType sType;
    void* pNext;
    VkShaderStageFlags stages;
    char name[VK_MAX_DESCRIPTION_SIZE];
    char description[VK_MAX_DESCRIPTION_SIZE];
    uint32_t subgroupSize;
    safe_VkPipelineExecutablePropertiesKHR(const VkPipelineExecutablePropertiesKHR* in_struct);
    safe_VkPipelineExecutablePropertiesKHR(const safe_VkPipelineExecutablePropertiesKHR& src);
    safe_VkPipelineExecutablePropertiesKHR& operator=(const safe_VkPipelineExecutablePropertiesKHR& src);
    safe_VkPipelineExecutablePropertiesKHR();
    ~safe_VkPipelineExecutablePropertiesKHR();
    void initialize(const VkPipelineExecutablePropertiesKHR* in_struct);
    void initialize(const safe_VkPipelineExecutablePropertiesKHR* src);
    VkPipelineExecutablePropertiesKHR *ptr() { return reinterpret_cast<VkPipelineExecutablePropertiesKHR *>(this); }
    VkPipelineExecutablePropertiesKHR const *ptr() const { return reinterpret_cast<VkPipelineExecutablePropertiesKHR const *>(this); }
};

struct safe_VkPipelineExecutableInfoKHR {
    VkStructureType sType;
    const void* pNext;
    VkPipeline pipeline;
    uint32_t executableIndex;
    safe_VkPipelineExecutableInfoKHR(const VkPipelineExecutableInfoKHR* in_struct);
    safe_VkPipelineExecutableInfoKHR(const safe_VkPipelineExecutableInfoKHR& src);
    safe_VkPipelineExecutableInfoKHR& operator=(const safe_VkPipelineExecutableInfoKHR& src);
    safe_VkPipelineExecutableInfoKHR();
    ~safe_VkPipelineExecutableInfoKHR();
    void initialize(const VkPipelineExecutableInfoKHR* in_struct);
    void initialize(const safe_VkPipelineExecutableInfoKHR* src);
    VkPipelineExecutableInfoKHR *ptr() { return reinterpret_cast<VkPipelineExecutableInfoKHR *>(this); }
    VkPipelineExecutableInfoKHR const *ptr() const { return reinterpret_cast<VkPipelineExecutableInfoKHR const *>(this); }
};

struct safe_VkPipelineExecutableStatisticKHR {
    VkStructureType sType;
    void* pNext;
    char name[VK_MAX_DESCRIPTION_SIZE];
    char description[VK_MAX_DESCRIPTION_SIZE];
    VkPipelineExecutableStatisticFormatKHR format;
    VkPipelineExecutableStatisticValueKHR value;
    safe_VkPipelineExecutableStatisticKHR(const VkPipelineExecutableStatisticKHR* in_struct);
    safe_VkPipelineExecutableStatisticKHR(const safe_VkPipelineExecutableStatisticKHR& src);
    safe_VkPipelineExecutableStatisticKHR& operator=(const safe_VkPipelineExecutableStatisticKHR& src);
    safe_VkPipelineExecutableStatisticKHR();
    ~safe_VkPipelineExecutableStatisticKHR();
    void initialize(const VkPipelineExecutableStatisticKHR* in_struct);
    void initialize(const safe_VkPipelineExecutableStatisticKHR* src);
    VkPipelineExecutableStatisticKHR *ptr() { return reinterpret_cast<VkPipelineExecutableStatisticKHR *>(this); }
    VkPipelineExecutableStatisticKHR const *ptr() const { return reinterpret_cast<VkPipelineExecutableStatisticKHR const *>(this); }
};

struct safe_VkPipelineExecutableInternalRepresentationKHR {
    VkStructureType sType;
    void* pNext;
    char name[VK_MAX_DESCRIPTION_SIZE];
    char description[VK_MAX_DESCRIPTION_SIZE];
    VkBool32 isText;
    size_t dataSize;
    void* pData;
    safe_VkPipelineExecutableInternalRepresentationKHR(const VkPipelineExecutableInternalRepresentationKHR* in_struct);
    safe_VkPipelineExecutableInternalRepresentationKHR(const safe_VkPipelineExecutableInternalRepresentationKHR& src);
    safe_VkPipelineExecutableInternalRepresentationKHR& operator=(const safe_VkPipelineExecutableInternalRepresentationKHR& src);
    safe_VkPipelineExecutableInternalRepresentationKHR();
    ~safe_VkPipelineExecutableInternalRepresentationKHR();
    void initialize(const VkPipelineExecutableInternalRepresentationKHR* in_struct);
    void initialize(const safe_VkPipelineExecutableInternalRepresentationKHR* src);
    VkPipelineExecutableInternalRepresentationKHR *ptr() { return reinterpret_cast<VkPipelineExecutableInternalRepresentationKHR *>(this); }
    VkPipelineExecutableInternalRepresentationKHR const *ptr() const { return reinterpret_cast<VkPipelineExecutableInternalRepresentationKHR const *>(this); }
};

struct safe_VkDebugReportCallbackCreateInfoEXT {
    VkStructureType sType;
    const void* pNext;
    VkDebugReportFlagsEXT flags;
    PFN_vkDebugReportCallbackEXT pfnCallback;
    void* pUserData;
    safe_VkDebugReportCallbackCreateInfoEXT(const VkDebugReportCallbackCreateInfoEXT* in_struct);
    safe_VkDebugReportCallbackCreateInfoEXT(const safe_VkDebugReportCallbackCreateInfoEXT& src);
    safe_VkDebugReportCallbackCreateInfoEXT& operator=(const safe_VkDebugReportCallbackCreateInfoEXT& src);
    safe_VkDebugReportCallbackCreateInfoEXT();
    ~safe_VkDebugReportCallbackCreateInfoEXT();
    void initialize(const VkDebugReportCallbackCreateInfoEXT* in_struct);
    void initialize(const safe_VkDebugReportCallbackCreateInfoEXT* src);
    VkDebugReportCallbackCreateInfoEXT *ptr() { return reinterpret_cast<VkDebugReportCallbackCreateInfoEXT *>(this); }
    VkDebugReportCallbackCreateInfoEXT const *ptr() const { return reinterpret_cast<VkDebugReportCallbackCreateInfoEXT const *>(this); }
};

struct safe_VkPipelineRasterizationStateRasterizationOrderAMD {
    VkStructureType sType;
    const void* pNext;
    VkRasterizationOrderAMD rasterizationOrder;
    safe_VkPipelineRasterizationStateRasterizationOrderAMD(const VkPipelineRasterizationStateRasterizationOrderAMD* in_struct);
    safe_VkPipelineRasterizationStateRasterizationOrderAMD(const safe_VkPipelineRasterizationStateRasterizationOrderAMD& src);
    safe_VkPipelineRasterizationStateRasterizationOrderAMD& operator=(const safe_VkPipelineRasterizationStateRasterizationOrderAMD& src);
    safe_VkPipelineRasterizationStateRasterizationOrderAMD();
    ~safe_VkPipelineRasterizationStateRasterizationOrderAMD();
    void initialize(const VkPipelineRasterizationStateRasterizationOrderAMD* in_struct);
    void initialize(const safe_VkPipelineRasterizationStateRasterizationOrderAMD* src);
    VkPipelineRasterizationStateRasterizationOrderAMD *ptr() { return reinterpret_cast<VkPipelineRasterizationStateRasterizationOrderAMD *>(this); }
    VkPipelineRasterizationStateRasterizationOrderAMD const *ptr() const { return reinterpret_cast<VkPipelineRasterizationStateRasterizationOrderAMD const *>(this); }
};

struct safe_VkDebugMarkerObjectNameInfoEXT {
    VkStructureType sType;
    const void* pNext;
    VkDebugReportObjectTypeEXT objectType;
    uint64_t object;
    const char* pObjectName;
    safe_VkDebugMarkerObjectNameInfoEXT(const VkDebugMarkerObjectNameInfoEXT* in_struct);
    safe_VkDebugMarkerObjectNameInfoEXT(const safe_VkDebugMarkerObjectNameInfoEXT& src);
    safe_VkDebugMarkerObjectNameInfoEXT& operator=(const safe_VkDebugMarkerObjectNameInfoEXT& src);
    safe_VkDebugMarkerObjectNameInfoEXT();
    ~safe_VkDebugMarkerObjectNameInfoEXT();
    void initialize(const VkDebugMarkerObjectNameInfoEXT* in_struct);
    void initialize(const safe_VkDebugMarkerObjectNameInfoEXT* src);
    VkDebugMarkerObjectNameInfoEXT *ptr() { return reinterpret_cast<VkDebugMarkerObjectNameInfoEXT *>(this); }
    VkDebugMarkerObjectNameInfoEXT const *ptr() const { return reinterpret_cast<VkDebugMarkerObjectNameInfoEXT const *>(this); }
};

struct safe_VkDebugMarkerObjectTagInfoEXT {
    VkStructureType sType;
    const void* pNext;
    VkDebugReportObjectTypeEXT objectType;
    uint64_t object;
    uint64_t tagName;
    size_t tagSize;
    const void* pTag;
    safe_VkDebugMarkerObjectTagInfoEXT(const VkDebugMarkerObjectTagInfoEXT* in_struct);
    safe_VkDebugMarkerObjectTagInfoEXT(const safe_VkDebugMarkerObjectTagInfoEXT& src);
    safe_VkDebugMarkerObjectTagInfoEXT& operator=(const safe_VkDebugMarkerObjectTagInfoEXT& src);
    safe_VkDebugMarkerObjectTagInfoEXT();
    ~safe_VkDebugMarkerObjectTagInfoEXT();
    void initialize(const VkDebugMarkerObjectTagInfoEXT* in_struct);
    void initialize(const safe_VkDebugMarkerObjectTagInfoEXT* src);
    VkDebugMarkerObjectTagInfoEXT *ptr() { return reinterpret_cast<VkDebugMarkerObjectTagInfoEXT *>(this); }
    VkDebugMarkerObjectTagInfoEXT const *ptr() const { return reinterpret_cast<VkDebugMarkerObjectTagInfoEXT const *>(this); }
};

struct safe_VkDebugMarkerMarkerInfoEXT {
    VkStructureType sType;
    const void* pNext;
    const char* pMarkerName;
    float color[4];
    safe_VkDebugMarkerMarkerInfoEXT(const VkDebugMarkerMarkerInfoEXT* in_struct);
    safe_VkDebugMarkerMarkerInfoEXT(const safe_VkDebugMarkerMarkerInfoEXT& src);
    safe_VkDebugMarkerMarkerInfoEXT& operator=(const safe_VkDebugMarkerMarkerInfoEXT& src);
    safe_VkDebugMarkerMarkerInfoEXT();
    ~safe_VkDebugMarkerMarkerInfoEXT();
    void initialize(const VkDebugMarkerMarkerInfoEXT* in_struct);
    void initialize(const safe_VkDebugMarkerMarkerInfoEXT* src);
    VkDebugMarkerMarkerInfoEXT *ptr() { return reinterpret_cast<VkDebugMarkerMarkerInfoEXT *>(this); }
    VkDebugMarkerMarkerInfoEXT const *ptr() const { return reinterpret_cast<VkDebugMarkerMarkerInfoEXT const *>(this); }
};

struct safe_VkDedicatedAllocationImageCreateInfoNV {
    VkStructureType sType;
    const void* pNext;
    VkBool32 dedicatedAllocation;
    safe_VkDedicatedAllocationImageCreateInfoNV(const VkDedicatedAllocationImageCreateInfoNV* in_struct);
    safe_VkDedicatedAllocationImageCreateInfoNV(const safe_VkDedicatedAllocationImageCreateInfoNV& src);
    safe_VkDedicatedAllocationImageCreateInfoNV& operator=(const safe_VkDedicatedAllocationImageCreateInfoNV& src);
    safe_VkDedicatedAllocationImageCreateInfoNV();
    ~safe_VkDedicatedAllocationImageCreateInfoNV();
    void initialize(const VkDedicatedAllocationImageCreateInfoNV* in_struct);
    void initialize(const safe_VkDedicatedAllocationImageCreateInfoNV* src);
    VkDedicatedAllocationImageCreateInfoNV *ptr() { return reinterpret_cast<VkDedicatedAllocationImageCreateInfoNV *>(this); }
    VkDedicatedAllocationImageCreateInfoNV const *ptr() const { return reinterpret_cast<VkDedicatedAllocationImageCreateInfoNV const *>(this); }
};

struct safe_VkDedicatedAllocationBufferCreateInfoNV {
    VkStructureType sType;
    const void* pNext;
    VkBool32 dedicatedAllocation;
    safe_VkDedicatedAllocationBufferCreateInfoNV(const VkDedicatedAllocationBufferCreateInfoNV* in_struct);
    safe_VkDedicatedAllocationBufferCreateInfoNV(const safe_VkDedicatedAllocationBufferCreateInfoNV& src);
    safe_VkDedicatedAllocationBufferCreateInfoNV& operator=(const safe_VkDedicatedAllocationBufferCreateInfoNV& src);
    safe_VkDedicatedAllocationBufferCreateInfoNV();
    ~safe_VkDedicatedAllocationBufferCreateInfoNV();
    void initialize(const VkDedicatedAllocationBufferCreateInfoNV* in_struct);
    void initialize(const safe_VkDedicatedAllocationBufferCreateInfoNV* src);
    VkDedicatedAllocationBufferCreateInfoNV *ptr() { return reinterpret_cast<VkDedicatedAllocationBufferCreateInfoNV *>(this); }
    VkDedicatedAllocationBufferCreateInfoNV const *ptr() const { return reinterpret_cast<VkDedicatedAllocationBufferCreateInfoNV const *>(this); }
};

struct safe_VkDedicatedAllocationMemoryAllocateInfoNV {
    VkStructureType sType;
    const void* pNext;
    VkImage image;
    VkBuffer buffer;
    safe_VkDedicatedAllocationMemoryAllocateInfoNV(const VkDedicatedAllocationMemoryAllocateInfoNV* in_struct);
    safe_VkDedicatedAllocationMemoryAllocateInfoNV(const safe_VkDedicatedAllocationMemoryAllocateInfoNV& src);
    safe_VkDedicatedAllocationMemoryAllocateInfoNV& operator=(const safe_VkDedicatedAllocationMemoryAllocateInfoNV& src);
    safe_VkDedicatedAllocationMemoryAllocateInfoNV();
    ~safe_VkDedicatedAllocationMemoryAllocateInfoNV();
    void initialize(const VkDedicatedAllocationMemoryAllocateInfoNV* in_struct);
    void initialize(const safe_VkDedicatedAllocationMemoryAllocateInfoNV* src);
    VkDedicatedAllocationMemoryAllocateInfoNV *ptr() { return reinterpret_cast<VkDedicatedAllocationMemoryAllocateInfoNV *>(this); }
    VkDedicatedAllocationMemoryAllocateInfoNV const *ptr() const { return reinterpret_cast<VkDedicatedAllocationMemoryAllocateInfoNV const *>(this); }
};

struct safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT {
    VkStructureType sType;
    void* pNext;
    VkBool32 transformFeedback;
    VkBool32 geometryStreams;
    safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT(const VkPhysicalDeviceTransformFeedbackFeaturesEXT* in_struct);
    safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT(const safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT& src);
    safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT& operator=(const safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT& src);
    safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT();
    ~safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT();
    void initialize(const VkPhysicalDeviceTransformFeedbackFeaturesEXT* in_struct);
    void initialize(const safe_VkPhysicalDeviceTransformFeedbackFeaturesEXT* src);
    VkPhysicalDeviceTransformFeedbackFeaturesEXT *ptr() { return reinterpret_cast<VkPhysicalDeviceTransformFeedbackFeaturesEXT *>(this); }
    VkPhysicalDeviceTransformFeedbackFeaturesEXT const *ptr() const { return reinterpret_cast<VkPhysicalDeviceTransformFeedbackFeaturesEXT const *>(this); }
};

struct safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT {
    VkStructureType sType;
    void* pNext;
    uint32_t maxTransformFeedbackStreams;
    uint32_t maxTransformFeedbackBuffers;
    VkDeviceSize maxTransformFeedbackBufferSize;
    uint32_t maxTransformFeedbackStreamDataSize;
    uint32_t maxTransformFeedbackBufferDataSize;
    uint32_t maxTransformFeedbackBufferDataStride;
    VkBool32 transformFeedbackQueries;
    VkBool32 transformFeedbackStreamsLinesTriangles;
    VkBool32 transformFeedbackRasterizationStreamSelect;
    VkBool32 transformFeedbackDraw;
    safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT(const VkPhysicalDeviceTransformFeedbackPropertiesEXT* in_struct);
    safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT(const safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT& src);
    safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT& operator=(const safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT& src);
    safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT();
    ~safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT();
    void initialize(const VkPhysicalDeviceTransformFeedbackPropertiesEXT* in_struct);
    void initialize(const safe_VkPhysicalDeviceTransformFeedbackPropertiesEXT* src);
    VkPhysicalDeviceTransformFeedbackPropertiesEXT *ptr() { return reinterpret_cast<VkPhysicalDeviceTransformFeedbackPropertiesEXT *>(this); }
    VkPhysicalDeviceTransformFeedbackPropertiesEXT const *ptr() const { return reinterpret_cast<VkPhysicalDeviceTransformFeedbackPropertiesEXT const *>(this); }
};

struct safe_VkPipelineRasterizationStateStreamCreateInfoEXT {
    VkStructureType sType;
    const void* pNext;
    VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
    uint32_t rasterizationStream;
    safe_VkPipelineRasterizationStateStreamCreateInfoEXT(const VkPipelineRasterizationStateStreamCreateInfoEXT* in_struct);
    safe_VkPipelineRasterizationStateStreamCreateInfoEXT(const safe_VkPipelineRasterizationStateStreamCreateInfoEXT& src);
    safe_VkPipelineRasterizationStateStreamCreateInfoEXT& operator=(const safe_VkPipelineRasterizationStateStreamCreateInfoEXT& src);
    safe_VkPipelineRasterizationStateStreamCreateInfoEXT();
    ~safe_VkPipelineRasterizationStateStreamCreateInfoEXT();
    void initialize(const VkPipelineRasterizationStateStreamCreateInfoEXT* in_struct);
    void initialize(const safe_VkPipelineRasterizationStateStreamCreateInfoEXT* src);
    VkPipelineRasterizationStateStreamCreateInfoEXT *ptr() { return reinterpret_cast<VkPipelineRasterizationStateStreamCreateInfoEXT *>(this); }
    VkPipelineRasterizationStateStreamCreateInfoEXT const *ptr() const { return reinterpret_cast<VkPipelineRasterizationStateStreamCreateInfoEXT const *>(this); }
};

struct safe_VkImageViewHandleInfoNVX {
    VkStructureType sType;
    const void* pNext;
    VkImageView imageView;
    VkDescriptorType descriptorType;
    VkSampler sampler;
    safe_VkImageViewHandleInfoNVX(const VkImageViewHandleInfoNVX* in_struct);
    safe_VkImageViewHandleInfoNVX(const safe_VkImageViewHandleInfoNVX& src);
    safe_VkImageViewHandleInfoNVX& operator=(const safe_VkImageViewHandleInfoNVX& src);
    safe_VkImageViewHandleInfoNVX();
    ~safe_VkImageViewHandleInfoNVX();
    void initialize(const VkImageViewHandleInfoNVX* in_struct);
    void initialize(const safe_VkImageViewHandleInfoNVX* src);
    VkImageViewHandleInfoNVX *ptr() { return reinterpret_cast<VkImageViewHandleInfoNVX *>(this); }
    VkImageViewHandleInfoNVX const *ptr() const { return reinterpret_cast<VkImageViewHandleInfoNVX const *>(this); }
};

struct safe_VkTextureLODGatherFormatPropertiesAMD {
    VkStructureType sType;
    void* pNext;
    VkBool32 supportsTextureGatherLODBiasAMD;
    safe_VkTextureLODGatherFormatPropertiesAMD(const VkTextureLODGatherFormatPropertiesAMD* in_struct);
    safe_VkTextureLODGatherFormatPropertiesAMD(const safe_VkTextureLODGatherFormatPropertiesAMD& src);
    safe_VkTextureLODGatherFormatPropertiesAMD& operator=(const safe_VkTextureLODGatherFormatPropertiesAMD& src);
    safe_VkTextureLODGatherFormatPropertiesAMD();
    ~safe_VkTextureLODGatherFormatPropertiesAMD();
    void initialize(const VkTextureLODGatherFormatPropertiesAMD* in_struct);
    void initialize(const safe_VkTextureLODGatherFormatPropertiesAMD* src);
    VkTextureLODGatherFormatPropertiesAMD *ptr() { return reinterpret_cast<VkTextureLODGatherFormatPropertiesAMD *>(this); }
    VkTextureLODGatherFormatPropertiesAMD const *ptr() const { return reinterpret_cast<VkTextureLODGatherFormatPropertiesAMD const *>(this); }
};

#ifdef VK_USE_PLATFORM_GGP
struct safe_VkStreamDescriptorSurfaceCreateInfoGGP {
    VkStructureType sType;
    const void* pNext;
    VkStreamDescriptorSurfaceCreateFlagsGGP flags;
    GgpStreamDescriptor streamDescriptor;
    safe_VkStreamDescriptorSurfaceCreateInfoGGP(const VkStreamDescriptorSurfaceCreateInfoGGP* in_struct);
    safe_VkStreamDescriptorSurfaceCreateInfoGGP(const safe_VkStreamDescriptorSurfaceCreateInfoGGP& src);
    safe_VkStreamDescriptorSurfaceCreateInfoGGP& operator=(const safe_VkStreamDescriptorSurfaceCreateInfoGGP& src);
    safe_VkStreamDescriptorSurfaceCreateInfoGGP();
    ~safe_VkStreamDescriptorSurfaceCreateInfoGGP();
    void initialize(const VkStreamDescriptorSurfaceCreateInfoGGP* in_struct);
    void initialize(const safe_VkStreamDescriptorSurfaceCreateInfoGGP* src);
    VkStreamDescriptorSurfaceCreateInfoGGP *ptr() { return reinterpret_cast<VkStreamDescriptorSurfaceCreateInfoGGP *>(this); }
    VkStreamDescriptorSurfaceCreateInfoGGP const *ptr() const { return reinterpret_cast<VkStreamDescriptorSurfaceCreateInfoGGP const *>(this); }
};
#endif // VK_USE_PLATFORM_GGP

struct safe_VkPhysicalDeviceCornerSampledImageFeaturesNV {
    VkStructureType sType;
    void* pNext;
    VkBool32 cornerSampledImage;
    safe_VkPhysicalDeviceCornerSampledImageFeaturesNV(const VkPhysicalDeviceCornerSampledImageFeaturesNV* in_struct);
    safe_VkPhysicalDeviceCornerSampledImageFeaturesNV(const safe_VkPhysicalDeviceCornerSampledImageFeaturesNV& src);
    safe_VkPhysicalDeviceCornerSampledImageFeaturesNV& operator=(const safe_VkPhysicalDeviceCornerSampledImageFeaturesNV& src);
    safe_VkPhysicalDeviceCornerSampledImageFeaturesNV();
    ~safe_VkPhysicalDeviceCornerSampledImageFeaturesNV();
    void initialize(const VkPhysicalDeviceCornerSampledImageFeaturesNV* in_struct);
    void initialize(const safe_VkPhysicalDeviceCornerSampledImageFeaturesNV* src);
    VkPhysicalDeviceCornerSampledImageFeaturesNV *ptr() { return reinterpret_cast<VkPhysicalDeviceCornerSampledImageFeaturesNV *>(this); }
    VkPhysicalDeviceCornerSampledImageFeaturesNV const *ptr() const { return reinterpret_cast<VkPhysicalDeviceCornerSampledImageFeaturesNV const *>(this); }
};

struct safe_VkExternalMemoryImageCreateInfoNV {
    VkStructureType sType;
    const void* pNext;
    VkExternalMemoryHandleTypeFlagsNV handleTypes;
    safe_VkExternalMemoryImageCreateInfoNV(const VkExternalMemoryImageCreateInfoNV* in_struct);
    safe_VkExternalMemoryImageCreateInfoNV(const safe_VkExternalMemoryImageCreateInfoNV& src);
    safe_VkExternalMemoryImageCreateInfoNV& operator=(const safe_VkExternalMemoryImageCreateInfoNV& src);
    safe_VkExternalMemoryImageCreateInfoNV();
    ~safe_VkExternalMemoryImageCreateInfoNV();
    void initialize(const VkExternalMemoryImageCreateInfoNV* in_struct);
    void initialize(const safe_VkExternalMemoryImageCreateInfoNV* src);
    VkExternalMemoryImageCreateInfoNV *ptr() { return reinterpret_cast<VkExternalMemoryImageCreateInfoNV *>(this); }
    VkExternalMemoryImageCreateInfoNV const *ptr() const { return reinterpret_cast<VkExternalMemoryImageCreateInfoNV const *>(this); }
};

struct safe_VkExportMemoryAllocateInfoNV {
    VkStructureType sType;
    const void* pNext;
    VkExternalMemoryHandleTypeFlagsNV handleTypes;
    safe_VkExportMemoryAllocateInfoNV(const VkExportMemoryAllocateInfoNV* in_struct);
    safe_VkExportMemoryAllocateInfoNV(const safe_VkExportMemoryAllocateInfoNV& src);
    safe_VkExportMemoryAllocateInfoNV& operator=(const safe_VkExportMemoryAllocateInfoNV& src);
    safe_VkExportMemoryAllocateInfoNV();
    ~safe_VkExportMemoryAllocateInfoNV();
    void initialize(const VkExportMemoryAllocateInfoNV* in_struct);
    void initialize(const safe_VkExportMemoryAllocateInfoNV* src);
    VkExportMemoryAllocateInfoNV *ptr() { return reinterpret_cast<VkExportMemoryAllocateInfoNV *>(this); }
    VkExportMemoryAllocateInfoNV const *ptr() const { return reinterpret_cast<VkExportMemoryAllocateInfoNV const *>(this); }
};

#ifdef VK_USE_PLATFORM_WIN32_KHR
struct safe_VkImportMemoryWin32HandleInfoNV {
    VkStructureType sType;
    const void* pNext;
    VkExternalMemoryHandleTypeFlagsNV handleType;
    HANDLE handle;
    safe_VkImportMemoryWin32HandleInfoNV(const VkImportMemoryWin32HandleInfoNV* in_struct);
    safe_VkImportMemoryWin32HandleInfoNV(const safe_VkImportMemoryWin32HandleInfoNV& src);
    safe_VkImportMemoryWin32HandleInfoNV& operator=(const safe_VkImportMemoryWin32HandleInfoNV& src);
    safe_VkImportMemoryWin32HandleInfoNV();
    ~safe_VkImportMemoryWin32HandleInfoNV();
    void initialize(const VkImportMemoryWin32HandleInfoNV* in_struct);
    void initialize(const safe_VkImportMemoryWin32HandleInfoNV* src);
    VkImportMemoryWin32HandleInfoNV *ptr() { return reinterpret_cast<VkImportMemoryWin32HandleInfoNV *>(this); }
    VkImportMemoryWin32HandleInfoNV const *ptr() const { return reinterpret_cast<VkImportMemoryWin32HandleInfoNV const *>(this); }
};
#endif // VK_USE_PLATFORM_WIN32_KHR

#ifdef VK_USE_PLATFORM_WIN32_KHR
struct safe_VkExportMemoryWin32HandleInfoNV {
    VkStructureType sType;
    const void* pNext;
    const SECURITY_ATTRIBUTES* pAttributes;
    DWORD dwAccess;
    safe_VkExportMemoryWin32HandleInfoNV(const VkExportMemoryWin32HandleInfoNV* in_struct);
    safe_VkExportMemoryWin32HandleInfoNV(const safe_VkExportMemoryWin32HandleInfoNV& src);
    safe_VkExportMemoryWin32HandleInfoNV& operator=(const safe_VkExportMemoryWin32HandleInfoNV& src);
    safe_VkExportMemoryWin32HandleInfoNV();
    ~safe_VkExportMemoryWin32HandleInfoNV();
    void initialize(const VkExportMemoryWin32HandleInfoNV* in_struct);
    void initialize(const safe_VkExportMemoryWin32HandleInfoNV* src);
    VkExportMemoryWin32HandleInfoNV *ptr() { return reinterpret_cast<VkExportMemoryWin32HandleInfoNV *>(this); }
    VkExportMemoryWin32HandleInfoNV const *ptr() const { return reinterpret_cast<VkExportMemoryWin32HandleInfoNV const *>(this); }
};
#endif // VK_USE_PLATFORM_WIN32_KHR

#ifdef VK_USE_PLATFORM_WIN32_KHR
struct safe_VkWin32KeyedMutexAcquireReleaseInfoNV {
    VkStructureType sType;
    const void* pNext;
    uint32_t acquireCount;
    VkDeviceMemory* pAcquireSyncs;
    const uint64_t* pAcquireKeys;
    const uint32_t* pAcquireTimeoutMilliseconds;
    uint32_t releaseCount;
    VkDeviceMemory* pReleaseSyncs;
    const uint64_t* pReleaseKeys;
    safe_VkWin32KeyedMutexAcquireReleaseInfoNV(const VkWin32KeyedMutexAcquireReleaseInfoNV* in_struct);
    safe_VkWin32KeyedMutexAcquireReleaseInfoNV(const safe_VkWin32KeyedMutexAcquireReleaseInfoNV& src);
    safe_VkWin32KeyedMutexAcquireReleaseInfoNV& operator=(const safe_VkWin32KeyedMutexAcquireReleaseInfoNV& src);
    safe_VkWin32KeyedMutexAcquireReleaseInfoNV();
    ~safe_VkWin32KeyedMutexAcquireReleaseInfoNV();
    void initialize(const VkWin32KeyedMutexAcquireReleaseInfoNV* in_struct);
    void initialize(const safe_VkWin32KeyedMutexAcquireReleaseInfoNV* src);
    VkWin32KeyedMutexAcquireReleaseInfoNV *ptr() { return reinterpret_cast<VkWin32KeyedMutexAcquireReleaseInfoNV *>(this); }
    VkWin32KeyedMutexAcquireReleaseInfoNV const *ptr() const { return reinterpret_cast<VkWin32KeyedMutexAcquireReleaseInfoNV const *>(this); }
};
#endif // VK_USE_PLATFORM_WIN32_KHR

struct safe_VkValidationFlagsEXT {
    VkStructureType sType;
    const void* pNext;
    uint32_t disabledValidationCheckCount;
    const VkValidationCheckEXT* pDisabledValidationChecks;
    safe_VkValidationFlagsEXT(const VkValidationFlagsEXT* in_struct);
    safe_VkValidationFlagsEXT(const safe_VkValidationFlagsEXT& src);
    safe_VkValidationFlagsEXT& operator=(const safe_VkValidationFlagsEXT& src);
    safe_VkValidationFlagsEXT();
    ~safe_VkValidationFlagsEXT();
    void initialize(const VkValidationFlagsEXT* in_struct);
    void initialize(const safe_VkValidationFlagsEXT* src);
    VkValidationFlagsEXT *ptr() { return reinterpret_cast<VkValidationFlagsEXT *>(this); }
    VkValidationFlagsEXT const *ptr() const { return reinterpret_cast<VkValidationFlagsEXT const *>(this); }
};

#ifdef VK_USE_PLATFORM_VI_NN
struct safe_VkViSurfaceCreateInfoNN {
    VkStructureType sType;
    const void* pNext;
    VkViSurfaceCreateFlagsNN flags;
    void* window;
    safe_VkViSurfaceCreateInfoNN(const VkViSurfaceCreateInfoNN* in_struct);
    safe_VkViSurfaceCreateInfoNN(const safe_VkViSurfaceCreateInfoNN& src);
    safe_VkViSurfaceCreateInfoNN& operator=(const safe_VkViSurfaceCreateInfoNN& src);
    safe_VkViSurfaceCreateInfoNN();
    ~safe_VkViSurfaceCreateInfoNN();
    void initialize(const VkViSurfaceCreateInfoNN* in_struct);
    void initialize(const safe_VkViSurfaceCreateInfoNN* src);
    VkViSurfaceCreateInfoNN *ptr() { return reinterpret_cast<VkViSurfaceCreateInfoNN *>(this); }
    VkViSurfaceCreateInfoNN const *ptr() const { return reinterpret_cast<VkViSurfaceCreateInfoNN const *>(this); }
};
#endif // VK_USE_PLATFORM_VI_NN

struct safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT {
    VkStructureType sType;
    const void* pNext;
    VkBool32 textureCompressionASTC_HDR;
    safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT(const VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT* in_struct);
    safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT(const safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT& src);
    safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT& operator=(const safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT& src);
    safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT();
    ~safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT();
    void initialize(const VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT* in_struct);
    void initialize(const safe_VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT* src);
    VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT *ptr() { return reinterpret_cast<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT *>(this); }
    VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT const *ptr() const { return reinterpret_cast<VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT const *>(this); }
};

struct safe_VkImageViewASTCDecodeModeEXT {
    VkStructureType 