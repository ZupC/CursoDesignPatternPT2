﻿using CursoDesignPatternPT2.cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatternPT2.cap4
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor visitor);
    }
}
