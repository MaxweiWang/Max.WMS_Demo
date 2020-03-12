﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Max.Core.Entity.Fluent.Validation
{
    public class StockOutFluent : AbstractValidator<Wms_stockout>
    {
        public StockOutFluent()
        {
            RuleFor(x => x.Remark).MaximumLength(200).WithMessage("备注长度不能超过200");
        }
    }
}