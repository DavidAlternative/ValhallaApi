﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class CreateVehicleValidator : AbstractValidator<CreateVehicleRequest>
    {
        public CreateVehicleValidator()
        {

        }
    }
}
