using BaseballEcommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace BaseballECommerce.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        // Define category IDs for reference
        var categories = new[]
        {
            new { CategoryId = new Guid("a1d4c053-49b6-410c-bc78-2d54a9991871"), CategoryName = "Baseball Caps", ImageUrl = "https://fanatics.frgimages.com/pittsburgh-pirates/mens-new-era-black-pittsburgh-pirates-game-authentic-collection-on-field-59fifty-fitted-hat_pi2659000_altimages_ff_2659222alt1_full.jpg?_hv=2&w=900" },
            new { CategoryId = new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"), CategoryName = "Memorabilia", ImageUrl = "https://images.footballfanatics.com/philadelphia-phillies/zack-wheeler-philadelphia-phillies-autographed-baseball_pi4477000_altimages_ff_4477423-b9ca33a41567f31fd77ealt1_full.jpg?_hv=2&w=900" },
            new { CategoryId = new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"), CategoryName = "Baseball Jerseys", ImageUrl = "https://fanatics.frgimages.com/san-francisco-giants/mens-nike-jung-hoo-lee-black-san-francisco-giants-alternate-limited-player-jersey_ss5_p-201932623+pv-1+u-80nxiobyxs5svhxbewgs+v-thc3l8ovqanbhhkfz30r.jpg?_hv=2&w=900" }
        };

        // Hardcoded GUIDs for products (50 products)
        var productGuids = new[]
        {
    Guid.Parse("d2a3bb2e-38fb-4a19-a639-fb4dbd364b7c"), Guid.Parse("bb8d41f0-b34d-4e6a-b2b7-51923f82a689"),
    Guid.Parse("8269d229-b4d9-40b3-a372-392e2ec5292b"), Guid.Parse("a4c1770b-5bb0-4302-bbf1-cfd85e5e2f84"),
    Guid.Parse("b8b63416-1a6e-46ba-a1e5-c0880a2b55b6"), Guid.Parse("4d30154f-35b5-471b-82fe-ef9a21f2ac01"),
    Guid.Parse("f34a8f09-57f6-4f78-b68e-8db8f1fcbff0"), Guid.Parse("9b365220-c8b7-4748-bdbf-b5574f2a8d57"),
    Guid.Parse("b7d1f37d-ff96-4c73-9f45-77dbd87cc5f6"), Guid.Parse("8a1c48f8-4c72-4ab7-9397-3de4e03bce4e"),
    Guid.Parse("e4d06271-8d33-478d-9502-0f2f9a23a2ad"), Guid.Parse("f8e5cbb7-4da7-467f-bfdb-df8fcf0b6f7f"),
    Guid.Parse("9e285a51-3d7e-4ccf-ae3e-1b9ad8b6d946"), Guid.Parse("dd6f6167-0547-45e3-a9ae-bf9d77b7d779"),
    Guid.Parse("c05951a2-33b2-4267-a09c-424a4b4de110"), Guid.Parse("d269ac3d-c739-4666-8ebf-e560318c3a32"),
    Guid.Parse("be3b76a2-0713-4751-b7e3-d13d3e5c39ba"), Guid.Parse("7ac4b639-4b0e-44ea-baa0-7b11a97053a3"),
    Guid.Parse("fc800db9-907b-40cf-9317-512ccfbc89e2"), Guid.Parse("572d7135-0a74-47b0-bf98-c4fa88561d38"),
    Guid.Parse("f4d24f9d-ea1a-4f64-a72b-c82468d563b0"), Guid.Parse("7c34ac72-3506-4f8d-b9e5-f253f506b29b"),
    Guid.Parse("91a6cb49-b9b7-44f1-a4a3-195e489af1a1"), Guid.Parse("d3463c97-d53e-420e-9c8a-c2b6c83f400f"),
    Guid.Parse("9a8882e0-d3b5-42f7-9b9e-01db2ea03393"), Guid.Parse("77327e42-e348-4771-b207-9f94a22f9c7b"),
    Guid.Parse("48c228c9-28c6-47c3-9e09-680ff4456745"), Guid.Parse("b1b6f0fc-b1a4-4d76-9abf-4a6a1b39b35f"),
    Guid.Parse("772b6b76-4870-4ca5-b8b0-e73a2f8bc299"), Guid.Parse("64f30770-89f3-4556-a4ba-d6b682b906e4"),
    Guid.Parse("d0ea219b-43d6-4878-8cf7-85708b50179b"), Guid.Parse("0c174c88-8e6c-4a7f-94ab-d4d08182d0f3"),
    Guid.Parse("9e0e429d-1c35-4646-8bc6-35d11de4a0da"), Guid.Parse("da5d8d1d-2c1a-4189-b14e-d02cfbff1058"),
    Guid.Parse("453a9375-e45f-423d-899d-b8e52e6a240a"), Guid.Parse("52b83dff-d91d-49b5-a9c1-2f10f0f72847"),
    Guid.Parse("6c8b07c1-87fc-44bc-b49e-d984b242b8d4"), Guid.Parse("99e3b59d-e9a6-4731-8b25-b5ecbde7b818"),
    Guid.Parse("98efb72f-5b50-41b4-bb0d-3ed28a1f0626"), Guid.Parse("024ac8d0-b451-4676-bf6b-00d493ed8498"),
    Guid.Parse("ab795f88-8d73-4851-94b7-50c6d974ee5f"), Guid.Parse("f156ab71-b581-4c2e-91c2-c931b59a5a50"),
    Guid.Parse("ad9fe62e-7ed7-4ef4-ae6e-0565c9c94db4"), Guid.Parse("c75b8131-bb87-4320-9ee7-20a1ef3fdca5"),
    Guid.Parse("6072ecb3-c529-42c4-babb-d5f8d32b773f"), Guid.Parse("1a5f410d-5972-4ca8-b237-b2b08d58e1da"),
    Guid.Parse("61e826fa-8507-470f-b8e6-bde742e9c41f"), Guid.Parse("91f4e38f-5173-4dfe-b2b5-7677a42f77ca"),
    Guid.Parse("3f85c759-c52f-43b4-92f9-0990ac775d09"), Guid.Parse("9a1fef92-9886-486b-983e-c73b3cc97359"),
    Guid.Parse("4e124e9e-5885-4c2c-983a-209b183635ad"), Guid.Parse("77fd7e2d-2447-4d53-a974-d8ec189c3d94"),
    Guid.Parse("9b7f8fbf-eac7-4124-9a5a-495948d44159"), Guid.Parse("d2fc524f-08ff-4894-85ea-2315d365d4fc"),
    Guid.Parse("12b03d8c-d825-4935-8f06-4372d3b9d1bb"), Guid.Parse("319bf7b2-5105-4267-94b3-e9bbd62d0b7d"),
    Guid.Parse("e8c2c1d9-0e2b-49c6-bf85-2e9e4dfd4100"), Guid.Parse("f9ac5077-b15d-4c98-a749-9c9c564b5736"),
    Guid.Parse("7cb1a2f9-9497-469e-91a2-b2b07e694ca0"), Guid.Parse("47d7ac56-482b-47d7-b415-2b77f8192255"),
    Guid.Parse("8a1773f2-df87-4633-9ae3-d7737060c8f6"), Guid.Parse("ad2a3e7d-4fd3-4b2f-828f-8208eaa28fe1"),
    Guid.Parse("fc597ae9-472b-42e2-b0a7-bc05e574f6fa"), Guid.Parse("62d8bff4-e090-4a2e-b4c9-c2c0d22668ad"),
    Guid.Parse("3f4d47a1-4ca0-4a9b-b477-98fd36a4b455"), Guid.Parse("c1a90377-6f67-4536-bb2c-96a87c0c6bfa"),
    Guid.Parse("a4a35b8d-cdd4-4bfe-b803-915ae24b7d3c"), Guid.Parse("9b4e2e9b-b9ab-4749-bd1f-d9bb7d66b939"),
    Guid.Parse("d0f76f92-eac4-471c-b0f9-67f066b4b0b1"), Guid.Parse("db450d4d-f9a7-438b-b632-b1ac4f81f2a5"),
    Guid.Parse("9d49be31-b2f1-47bc-bc79-97c755ddfb39"), Guid.Parse("0d58a768-1d64-4c42-9e0a-2b2de3a24f7b"),
    Guid.Parse("153eaf78-982a-40fe-8fe5-70f5272cb520"), Guid.Parse("be4fe803-b4ed-4f7e-bef4-b3d38319e739"),
    Guid.Parse("b2cd032f-f7d4-4d68-a91a-82e2ff9577a7"), Guid.Parse("8c679fdb-29b3-49d1-bfd8-df7e7b8c99e5"),
    Guid.Parse("fb5be6f8-3f01-4e34-80c3-53a83a410c9b"), Guid.Parse("af245e8a-c13c-48eb-b282-7cdbb3f62ed9"),
    Guid.Parse("7acb06fa-51c7-4333-9021-fbe4cc9d4632"), Guid.Parse("f1536941-d49f-4705-9b69-8e58ed60743e"),
    Guid.Parse("e97f57a2-e4cc-4202-b1d3-52a9b8fa4f83"), Guid.Parse("378c63fc-e402-4d08-a569-4734cc7ea6ea"),
    Guid.Parse("66cf88d0-cb26-423b-85fd-85fa9292d91f"), Guid.Parse("b545f118-6589-42d5-a730-07c982b80647"),
    Guid.Parse("5fa767c8-e602-42a2-b0a1-1e9f1186e771"), Guid.Parse("c60205c0-fb57-4a07-bb79-2ef2323c0f71"),
    Guid.Parse("1b61d8b7-d038-4fd8-90b7-f456202b6be0"), Guid.Parse("7c6252fc-b3f1-47f1-87fc-e64a60e87e17"),
    Guid.Parse("e276b918-fd26-46f7-b704-8f9a2c14e768"),
Guid.Parse("df6fe6a2-1cd3-4fd9-a470-745056548578"),
Guid.Parse("c8253c2b-d1d2-49a4-becf-3d64f2d07ca2"),
Guid.Parse("1fa0f566-e905-4df8-a9a1-b2f7a991b1d2"),
Guid.Parse("9ed79592-2993-4f52-9cfb-0c4b47a88ca3"),
Guid.Parse("57eb0f78-3cf2-4c7f-9522-fd3a4f3b72b5"),
Guid.Parse("bc1a7dff-8c7f-4558-8bfa-86fe9ff478bb"),
Guid.Parse("ac5f3d06-ada6-47fd-8bb5-68c1f2d6c0d4"),
Guid.Parse("42846dbe-e12f-4ac5-b29a-e9b1b6f57cd2"),
Guid.Parse("bbff8167-4a6d-4307-97f4-cc8ebfbb7683"),
Guid.Parse("1a52f78e-7307-41b0-88b4-6a2f48f04e18"),
Guid.Parse("9a2c2a77-df96-460f-bf26-9b36b70b6d6e"),
Guid.Parse("362cd945-b98c-4529-b7ab-d1f6fd990d8f"),
Guid.Parse("c6d4d8d0-b60a-4dff-bd6b-cfcd1d64ad98"),
Guid.Parse("264e0793-436b-48db-9c3b-42941c43b2db"),
Guid.Parse("7469a1f5-ea63-4538-9f80-e25158f431a4"),
Guid.Parse("0b6362cc-2551-4152-9b94-2ae5fe1a0355"),
Guid.Parse("862528d7-3ff3-4d7d-848f-0dcd9bb91567"),
Guid.Parse("51803361-171e-4421-9b6e-8ff1c6cfd017"),
Guid.Parse("7cf539ac-62d1-47d4-b3f2-b9d674cc6137"),
Guid.Parse("ff637be4-d0a0-4764-9e80-ec8c126b23d2"),
Guid.Parse("267c3707-d02d-48e6-9e70-bc46302e4f1b"),
Guid.Parse("b00a3588-4e1d-45db-8be2-f3bb4b9fc5d5"),
Guid.Parse("b70f7097-5de0-48cd-9d42-2f3d040d9b2b"),
Guid.Parse("8157cb1c-17e1-4856-bd9a-45392dff6ef5"),
Guid.Parse("228a11a0-3c82-4c11-b26a-88c622aa56ac"),
Guid.Parse("a9f7425e-84cd-4441-988f-8ff16c6e496f"),
Guid.Parse("03b9a538-50cc-4d88-9a2e-8b244f19e531"),
Guid.Parse("8761ac7e-b235-4be1-9f27-03bb76054e79"),
Guid.Parse("3129a2f3-bb70-47ca-89e3-e2c93d9d8f9a"),
Guid.Parse("1d2e44e6-0d07-4f99-bd95-02438d0fa404"),
Guid.Parse("5b5fd4e0-d906-4f7a-9a1f-bbb9d307d3a3"),
Guid.Parse("7de9a063-7921-47ed-9f5d-08c4578e4fe2"),
Guid.Parse("497b731b-13a2-4017-8f73-cbb6f5222cf0"),
Guid.Parse("0ac6fa91-35f6-4f10-bc8e-bdbac1b06c6f"),
Guid.Parse("8c8a4bbf-ccfc-4ac7-b02b-d85b67ca1a9c"),
Guid.Parse("320c9a31-1181-47ae-a193-801bbda168e2"),
Guid.Parse("1ea65c52-bcf5-4c3d-baad-fd5fc63ef8d7"),
Guid.Parse("d8be0f56-c6da-4c8e-a2de-2a445506b256"),
Guid.Parse("df15c3c1-0eb5-4f90-83e6-b92416cd3c18"),
Guid.Parse("d1002b01-4bba-4a4f-8f98-e5ed4505ac9f"),
Guid.Parse("d84c75e5-dc56-43e1-99e2-619e5758ff02"),
Guid.Parse("13acb149-adaf-43d5-a9e4-0ec8f33ac92c"),
Guid.Parse("2180552f-0d29-48ad-8c7e-c6a2c8e858c3"),
Guid.Parse("3c26b582-cbfe-4629-9eb1-b1a2a3c9b7b1"),
Guid.Parse("d5e6538e-94f5-4f67-9c9f-053be34e4fc9"),
Guid.Parse("9c3fdd9f-79b9-4202-9634-d88f36e3b3c0"),
Guid.Parse("f57454f2-3c96-4e8e-b39a-4a3189eea8e7"),
Guid.Parse("39be25f2-f2d8-49d6-a0b2-c5db7ef9ad01"),
Guid.Parse("c17543c5-0d9e-44a9-820d-b0c7b7d7e38f"),
Guid.Parse("92fd6941-91e3-4529-b4a6-6fc88f226f56"),
Guid.Parse("da0a25d3-5d5f-4960-b54e-86f87f7b14d3"),
Guid.Parse("83ac5c8e-c2b7-4d3c-8f13-e4c46360b0a5"),
Guid.Parse("d9a2f820-0f02-4e16-80fc-b1d55ed5ff94"),
Guid.Parse("bb8a201e-6ffb-45e2-8b2e-1280d970c282"),
Guid.Parse("38fc5c3a-fb95-4874-b7e4-08b204520fb9"),
Guid.Parse("b8037c62-d4f3-4715-92b1-1f26f51cc28c"),
Guid.Parse("7a88b859-bf68-47a1-8830-c75f5e14c0e9"),
Guid.Parse("d9844e69-1468-4d69-b832-e6123a4679b0"),
Guid.Parse("5977a489-d625-40d1-8f4d-e14f8e6e571d"),
Guid.Parse("0738b566-b8a1-488b-b149-20a13b431c8a"),
Guid.Parse("d64e16e4-8b72-40c4-bf8e-92811ff9a0b2")


};


        // Iterate through categories and create 50 products for each
        int productIndex = 0;
        foreach (var category in categories)
        {
            for (int i = 0; i < 50; i++)
            {
                var productId = productGuids[productIndex]; // Use the pre-generated GUID
                productIndex++; // Increment for each new product

                builder.HasData(
                    new Product
                    {
                        Id = productId,
                        Name = $"{category.CategoryName} Product {i}",
                        Description = $"{category.CategoryName} product {i} description.",
                        ListPrice = (double)(30.00m + i), // Adjust price based on index for variety
                        CategoryId = category.CategoryId,
                        ImageUrl = category.ImageUrl,
                        StockQuantity = 50
                    }
                );
            }
        }
    }
}
