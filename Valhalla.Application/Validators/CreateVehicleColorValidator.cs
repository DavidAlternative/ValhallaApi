using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class CreateVehicleColorValidator : AbstractValidator<CreateVehicleColorRequest>
    {
        public CreateVehicleColorValidator()
        {

        }
    }
}
