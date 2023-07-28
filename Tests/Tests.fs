module Tests

open Xunit

let sku = Sku.SkuName Sku.n64

[<Fact>]
let ``My test`` () =
    Assert.True true
