using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class UpdateVehicleColorValidator : AbstractValidator<UpdateVehicleColorRequest>
    {
        public UpdateVehicleColorValidator()
        {

        }
    }
}
