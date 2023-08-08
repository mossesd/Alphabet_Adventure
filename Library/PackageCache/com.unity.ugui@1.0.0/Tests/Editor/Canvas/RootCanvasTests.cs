 "'Base'");
    InstructionDesc[OpBitFieldUExtract].operands.push(OperandId, "'Offset'");
    InstructionDesc[OpBitFieldUExtract].operands.push(OperandId, "'Count'");
    
    InstructionDesc[OpBitReverse].operands.push(OperandId, "'Base'");

    InstructionDesc[OpBitCount].operands.push(OperandId, "'Base'");

    InstructionDesc[OpSelect].operands.push(OperandId, "'Condition'");
    InstructionDesc[OpSelect].operands.push(OperandId, "'Object 1'");
    InstructionDesc[OpSelect].operands.push(OperandId, "'Object 2'");

    InstructionDesc[OpIEqual].operands.push(OperandId, "'Operand 1'");
    InstructionDesc[OpIEqual].operands.push(OperandId, "'Operand 2'");

    InstructionDesc[OpFOrdEqual].operands.push(OperandId, "'Operand 1'");
    InstructionDesc[OpFOrdEqual].operands.push(OperandId, "'Operand 2'");

    InstructionDesc[OpFUnordEqual].operands.push(OperandId, "'Operand 1'");
    InstructionDesc[OpFUnordEqual].operands.push(OperandId, "'Operand 2'");

    InstructionDesc[OpINotEqual].operands.push(OperandId, "'Operand 1'");
    InstructionDesc[OpINotEqual].operands.push(OperandId, "'Operand 2'");

    InstructionDesc[OpFOrdNotEqual].operands.push(OperandId, "'Operand 1'");
    InstructionDesc[OpFOrdNotEqual].operands.push(OperandId, "'Operand 2'");

    InstructionDesc[OpFUnordNotEqual].operands.push(OperandId, "'Operand 1'");
    InstructionDesc[OpFUnordNotEqual].operands.push(OperandId, "'Operand 2'");

    InstructionDesc[OpULessThan].operands.push(OperandId, "'Operand 1'