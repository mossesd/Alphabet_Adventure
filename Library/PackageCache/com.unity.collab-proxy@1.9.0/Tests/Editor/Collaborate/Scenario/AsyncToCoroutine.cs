criptorUpdateAfterBindSamplers limit (%d). VUID-VkPipelineLayoutCreateInfo-descriptorType-03023 vkCreatePipelineLayout(): max per-stage uniform buffer bindings count (%d) exceeds device maxPerStageDescriptorUpdateAfterBindUniformBuffers limit (%d). VUID-VkPipelineLayoutCreateInfo-descriptorType-03024 vkCreatePipelineLayout(): max per-stage storage buffer bindings count (%d) exceeds device maxPerStageDescriptorUpdateAfterBindStorageBuffers limit (%d). VUID-VkPipelineLayoutCreateInfo-descriptorType-03025 vkCreatePipelineLayout(): max per-stage sampled image bindings count (%d) exceeds device maxPerStageDescriptorUpdateAfterBindSampledImages limit (%d). VUID-VkPipelineLayoutCreateInfo-descriptorType-03026 vkCreatePipelineLayout(): max per-stage storage image bindings count (%d) exceeds device maxPerStageDescriptorUpdateAfterBindStorageImages limit (%d). VUID-VkPipelineLayoutCreateInfo-descriptorType-03027 vkCreatePipelineLayout(): max per-stage input attachment bindings count (%d) exceeds device maxPerStageDescriptorUpdateAfterBindInputAttachments limit (%d). VUID-VkPipelineLayoutCreateInfo-descriptorType-02215 vkCreatePipelineLayout(): max per-stage inline uniform block bindings count (%d) exceeds device maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03036 vkCreatePipelineLayout(): sum of sampler bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindSamplers limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03037 vkCreatePipelineLayout(): sum of uniform buffer bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindUniformBuffers limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03038 vkCreatePipelineLayout(): sum of dynamic uniform buffer bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindUniformBuffersDynamic limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03039 vkCreatePipelineLayout(): sum of storage buffer bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindStorageBuffers limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03040 vkCreatePipelineLayout(): sum of dynamic storage buffer bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindStorageBuffersDynamic limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03041 vkCreatePipelineLayout(): sum of sampled image bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindSampledImages limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03042 vkCreatePipelineLayout(): sum of storage image bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindStorageImages limit (%d). VUID-VkPipelineLayoutCreateInfo-pSetLayouts-03043 vkCreatePipelineLayout(): sum of input attachment bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindInputAttachments limit (%d). VUID-VkPipelineLayoutCreateInfo-descriptorType-02217 vkCreatePipelineLayout(): sum of inline uniform block bindings among all stages (%d) exceeds device maxDescriptorSetUpdateAfterBindInlineUniformBlocks limit (%d). VUID-vkResetDescriptorPool-descriptorPool-00313 It is invalid to call vkResetDescriptorPool() with descriptor sets in use by a command buffer. vkFreeDescriptorSets VUID-vkFreeDescriptorSets-descriptorPool-00312 It is invalid to call vkFreeDescriptorSets() with a pool created without setting VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT. vkUpdateDescriptorSets() VUID-vkBeginCommandBuffer-commandBuffer-00049 Calling vkBeginCommandBuffer() on active %s before it has completed. You must check command buffer fence before this call. VUID-vkBeginCommandBuffer-commandBuffer-00051 vkBeginCommandBuffer(): Secondary %s must have inheritance info. framebuffer command buffer vkBeginCommandBuffer() VUID-VkCommandBufferBeginInfo-flags-00055 VUID-vkBeginCommandBuffer-commandBuffer-00052 vkBeginCommandBuffer(): Secondary %s must not have VK_QUERY_CONTROL_PRECISE_BIT if occulusionQuery is disabled or the device does not support precise occlusion queries. VUID-VkCommandBufferBeginInfo-flags-00054 vkBeginCommandBuffer(): Secondary %s must have a subpass index (%d) that is less than the number of subpasses (%d). vkBeginCommandBuffer(): Cannot call Begin on %s in the RECORDING state. Must first call vkEndCommandBuffer(). VUID-vkBeginCommandBuffer-commandBuffer-00050 Call to vkBeginCommandBuffer() on %s attempts to implicitly reset cmdBuffer created from %s that does NOT have the VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT bit set. VUID-VkDeviceGroupCommandBufferBeginInfo-deviceMask-00106 VUID-VkDeviceGroupCommandBufferBeginInfo-deviceMask-00107 vkEndCommandBuffer() VUID-vkEndCommandBuffer-commandBuffer-00060 VUID-vkEndCommandBuffer-commandBuffer-00061 Ending command buffer with in progress query: %s, query %d. VUID-vkResetCommandBuffer-commandBuffer-00046 Attempt to reset %s created from %s that does NOT have the VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT bit set. reset VUID-vkResetCommandBuffer