﻿using AutoMapper;
using KargomentoBL.InterfacesOfManagers;
using KargomentoDL.InterfacesOfRepo;
using KargomentoEL.Models;
using KargomentoEL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargomentoBL.ImplementationsOfManagers
{
    public class CargoStatusManager : Manager<CargoStatusVM, CargoStatus, int>, ICargoStatusManager
    {
        public CargoStatusManager(ICargoStatusRepo repo, IMapper mapper)
            : base(repo, mapper, null)
        {
        }
    }
}
