using FluentValidation;

namespace Max.Core.Entity.Fluent.Validation
{
    public class SysCompanyWXWFluent : AbstractValidator<Sys_companyWXW>
    {
        public SysCompanyWXWFluent()
        {
            RuleFor(x => x.CompanyWXWNo).NotNull().NotEmpty().WithMessage("公司编号不能为空").Length(1, 20).WithMessage("公司编号长度不能超过20");
            RuleFor(x => x.CompanyWXWName).NotNull().NotEmpty().WithMessage("公司名称不能为空").Length(1, 50).WithMessage("公司名称长度不能超过50");
            RuleFor(x => x.Remark).MaximumLength(200).WithMessage("备注长度不能超过200");
        }
    }
}
