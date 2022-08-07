using FluentValidation;
using Valhalla.Application.Requests;

namespace Valhalla.Application.Validators
{

    public class UpdateVehicleValidator : AbstractValidator<UpdateVehicleRequest>
    {
        public UpdateVehicleValidator()
        {

        }
    }
}
