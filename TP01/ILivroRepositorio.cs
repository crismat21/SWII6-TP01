﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    interface ILivroRepositorio
    {
        Library Library { get; }
        IEnumerable<Book> All { get; }
    }
}
