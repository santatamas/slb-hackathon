﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackaton;

namespace C64Emulator
{
    partial class Processor
    {
        private void INX(AddressingMode mode)
        {
            X++;
            StatusZ = X == 0;
            StatusN = X > 127;
            PC++;
        }
    }
}
