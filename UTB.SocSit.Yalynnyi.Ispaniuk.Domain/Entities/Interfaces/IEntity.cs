﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities.Interfaces
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime Created { get; set; }
    }
}
