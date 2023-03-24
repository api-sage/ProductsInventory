using FluentValidation;
using ProductInventoryMgt.Model.Domain;
using ProductInventoryMgt.Model.DTO;

namespace ProductInventoryMgt.Validations
{
    public class Programs : AbstractValidator<AddProduct>
    {
        public Programs()
        {
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.QtyReceived).GreaterThan(0);
            RuleFor(x => x.QtyReceived).NotEmpty();
            RuleFor(x => x.QtySold).NotEmpty();
            RuleFor(x => x.QtySold).GreaterThan(0);
            RuleFor(x => x.Status).NotEmpty();
        }
    }
}
