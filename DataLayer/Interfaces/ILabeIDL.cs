﻿using Models.DTOs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface ILabelDL
    {
        Task<LabelDto> AddLabelsToDb(Label label);
    }
}
