using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{
    public class DeleteVehicleColorValidator : AbstractValidator<DeleteVehicleColorRequest>
    {
        public DeleteVehicleColorValidator()
        {

        }
    }
}
