B=ConvOclDirectFwd:8,8,16,16,2,2,8,2,1
128-14-14-1x1-528-14-14-32-0x0-1x1-1x1-0-NCHW-FP32-B=ConvAsm1x1U:1,16,1,32,4,2,1,4;ConvOclDirectFwd1x1:1,128,1,1,0,4,16,4,0
16-14-14-1x1-480-14-14-256-0x0-1x1-1x1-0-NCHW-FP32-B=ConvAsm1x1U:1,32,1,64,1,1,1,2;ConvOclDirectFwd1x1:1,128,1,1,0,1,32,4,0
128-28-28-1x1-256-56-56-8-0x0-2x2-1x1-0-NCHW-FP16-W=ConvAsmBwdWrW1x1:4,4,4,1,8,1,1,4,0,1
128-14-14-1x1-800-14-14-256-0x0-1x1-1x1-0-NCHW-FP16-W=ConvAsmBwdWrW1x1:2,8,4,8,2,1,2,4,0,1
96-35-35-3x3-64-35-35-1-1x1-1x1-1x1-0-NCHW-FP16-B=ConvOclDirectFwd:16,16,16,16,1,1,2,4,1
288-56-56-1x1-192-56-56-16-0x0-1x1-1x1-0-NCHW-FP16-F=ConvAsm1x1U:1,8,2,64,2,4,1,8;ConvOclDirectFwd1x1:1,64,1,1,0,4,16,4,0
256-8-8-1x1-1536-8-8-64-0x0-1x1-1x1-0-NCHW-FP16-B=ConvAsm1x1U:1,16,2,16,1,2,2,4;ConvOclDirectFwd1x1:1,64,1,1,0,4,16,4,0
256-27-27-1x1-32-27-27-256-0x0-1x1-1x1-0-NCHW-FP32-B=ConvAsm1x1U:2,32,2,64,1,1,1,1;ConvOclDirectFwd1x1:1,256,1,1,0,1,16,8,0
896-14-14-1x1-128-14-14-128-0x0-1x1-1x1-0-NCHW-FP32-W=ConvAsmBwdWrW1x1:2,8,4,8,4,2,2,4,0,1
128-54-54-1x1-32-54-54-256-0x0-1x1-1x1-0-NCHW-FP32-B=ConvAsm1x1U:1,32,1,64,1,1,1,1;ConvOclDirectFwd1x1:1,128,1,1,0,1,32,4,0
320-28-28-1x1-128-28-28-256-0x0-1x1-1x1-0-NCHW-FP32-W=ConvAsmBwdWrW1x1:2,8,2,4,4,2,2,4,0,1
64-35-35-1x1-192-35-35-8-0x0-1x1-1x1-0-NCHW-FP32-B=ConvAsm1x1U:1,16,1,64,1,2,2,2;ConvOclDirectFwd1x1:1,64,1,1,0,1,8,4,0
1024-17-17-1x1-128-17-17-256-0x0-1x1-1x1-0-NCHW-FP32-W=ConvAsmBwdWrW1x1:2,8,4,8,4,1,2,4,0,2
192-17-17-3x3-320-8-8-128-0x0-2x2-1x1-0-NCHW-FP32-F=ConvOclDirectFwd:8,8,8,8,1,1,8,2,1
1968-14-14-1x1-192-14-14-16-0x0-1x1-1x1-0-NCHW-FP32-F=ConvAsm1x1U:4,8,7,32,1,2,2,2;ConvActivAsm1x1U:3,16,3,16,4,4;ConvOclDirectFwd1x1:1,64,1,1,1,4,16,256,0
96-17-17-3x3-96-35-35-16-0x0-2x2-1x1-0-NCHW-FP32-B=ConvOclDirectFwd:16,16,16,16,1,1,4,1,2
768-17-17-1x1-128-17-17-16-0x0-1x1-1x1-0-NCHW-FP32-F=ConvAsm1x1U:2,16,5,64,1,2,4,1;ConvActivAsm1x1U:3,16,5,64,1,4;ConvOclDirectFwd1x1:1,64,1,1,1,0,32,256,0
96-14-14-1x1-480-14-14-1-0x0-1x1-1x1-0-NCHW-FP32-W=ConvAsmBwdWrW1x1:1,16,4,2,2,1,1,4,0,1
16-54-54-1x1-64-54-54-128-0x0-1x1-1x1-0-NCHW-FP16-W=ConvAsmBwdWrW1x1:4,4,2,1,2,2,4,4,0,2
256-13-13-1x1-64-13-13-32-0x0-1x1-1x1-0-NCHW-FP32-B=ConvAsm1x1U:1,16,1,64,1,1,4,2;ConvOclDirectFwd1x1:1,128,1,1,0,1,8,4,0
2048-7-7-1x1-512-7