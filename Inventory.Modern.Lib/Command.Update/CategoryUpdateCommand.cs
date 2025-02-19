﻿using AutoMapper;
using CRUDCommandHelper;
using Inventory.Data;
using Serilog;

namespace Inventory.Modern.Lib;

public class CategoryUpdateCommand
    : UpdateCommand<IInventoryUnitOfWork, Category, CategoryArgUpdate, CategoryUpdate>
{
    public CategoryUpdateCommand(
        IInventoryUnitOfWork unitOfWork
        , ILogger log
        , IMapper mapper)
            : base(unitOfWork, log, mapper)
    {
    }

    protected override Category GetById(int id) =>
        UnitOfWork.Category.GetById(id) ?? new Category();
}