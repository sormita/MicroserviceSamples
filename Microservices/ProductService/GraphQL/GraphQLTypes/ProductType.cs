using ProductService.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.GraphQL.GraphQLTypes
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.ProductId, type: typeof(IdGraphType)).Description("some desc here");
            Field(x => x.Name).Description("some desc here");
            Field(x => x.ProductNumber).Description("some desc here");
            Field(x => x.MakeFlag).Description("some desc here");
            Field(x => x.FinishedGoodsFlag).Description("some desc here");
            Field(x => x.Color).Description("some desc here");
            //Field(x => x.SafetyStockLevel, type: typeof(ShortGraphType)).Description("some desc here");
            //Field(x => x.ReorderPoint, type: typeof(ShortGraphType)).Description("some desc here");
            Field(x => x.StandardCost).Description("some desc here");
            Field(x => x.ListPrice).Description("some desc here");
            Field(x => x.Size).Description("some desc here");
            Field(x => x.SizeUnitMeasureCode).Description("some desc here");
            Field(x => x.WeightUnitMeasureCode).Description("some desc here");
            Field(x => x.Weight, nullable: true, type: typeof(DecimalGraphType)).Description("some desc here");
            Field(x => x.DaysToManufacture).Description("some desc here");
            Field(x => x.ProductLine).Description("some desc here");
            Field(x => x.Class).Description("some desc here");
            Field(x => x.Style).Description("some desc here");
            Field(x => x.ProductSubcategoryId, nullable: true, type: typeof(IntGraphType)).Description("some desc here");
            Field(x => x.ProductModelId, nullable: true, type: typeof(IntGraphType)).Description("some desc here");
            Field(x => x.SellStartDate).Description("some desc here");
            Field(x => x.SellEndDate, nullable: true, type: typeof(DateGraphType)).Description("some desc here");
            Field(x => x.DiscontinuedDate, nullable: true, type: typeof(DateGraphType)).Description("some desc here");
            //Field(x => x.Rowguid).Description("some desc here");
            Field(x => x.ModifiedDate).Description("some desc here");            
        }
    }
}
