using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.MainBoundedContext.DgtModule.Aggregates.VehicleAgg;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.InitialData
{
    public static class EntityGuids
    {
        public static class Drivers
        {
            public static Guid IagoAspas = new Guid("bbe34513-f141-47e4-91c5-5515c8e6be3f");
            public static Guid NemanjaRadoja = new Guid("56eb93f6-6327-4a33-8969-34adf528af93");
            public static Guid FranBeltran = new Guid("2f700442-b36b-419b-a28c-9a7e0c7bd5e4");
        }

        public static class Vehicles
        {
            public static Guid FerrariGTO = new Guid("9d6a4ddd-6273-4e0a-ad8e-646b8c63b175");
            public static Guid BmwM3 = new Guid("08ef46a2-f0f7-4e69-8154-0547ea779872");
            public static Guid SeatLeon = new Guid("5051c165-c7f8-4c76-ad76-ecf65deb74f5");
        }

        public static class InfractionTypes
        {
            public static Guid ExcesoVelocidad20 = new Guid("d8cda5d4-452d-419f-8301-116671115623");
            public static Guid ExcesoVelocidad40 = new Guid("1a259575-8f80-44ec-8d5a-4213c4ac7f06");
            public static Guid ExcesoVelocidad60 = new Guid("a7ca4248-3ec9-4f35-90ed-2f0681ef9114");
            public static Guid DobleFila = new Guid("deb907d3-1341-4dd6-826f-b765e8afda16");
            public static Guid SinCinturonSeguridad = new Guid("1fb833dc-6bad-4e89-a858-226e6c2fefa8");
        }

        public static class Brands
        {
            public static Guid AbarthBrandId = new Guid("50ed8514-fec6-46cb-b914-34d40e93710b");
            public static Guid AlfaRomeoBrandId = new Guid("7dab8ad6-0d8e-4318-861e-df4a9ecd7845");
            public static Guid AlpineBrandId = new Guid("090cc18f-ff4b-40fa-88b6-5a69453a0567");
            public static Guid AstonMartinBrandId = new Guid("c54a5b97-8ab3-42bf-bfda-0d4823f86bee");
            public static Guid AudiBrandId = new Guid("64ace552-8947-4e4e-a592-f2a9e1bd119f");
            public static Guid BentleyBrandId = new Guid("a994ceff-b8bb-4e30-a5e5-6064e47185eb");
            public static Guid BMWBrandId = new Guid("fd198954-3df6-467b-8dbc-b0feab956391");
            public static Guid BugattiBrandId = new Guid("e206aeda-3375-485b-847c-ad8c753c6a9e");
            public static Guid BYDBrandId = new Guid("4189b8d0-5a47-458d-8982-00eca08b7e94");
            public static Guid CadillacBrandId = new Guid("90030b41-9d19-479e-adc6-decb97fe9a31");
            public static Guid CaterhamBrandId = new Guid("25f1f56c-4832-45d7-a1e1-d82ff4c9c18f");
            public static Guid ChevroletBrandId = new Guid("f3bdbbc3-e233-48f6-a085-2764106624fd");
            public static Guid CitroënBrandId = new Guid("a22e5c9c-2bd7-4680-add6-99d19766eaf6");
            public static Guid CupraBrandId = new Guid("3e276dab-ff88-4ea4-9428-8ed94d5c3251");
            public static Guid DaciaBrandId = new Guid("29bb9b99-3462-4f39-a828-e401a06d762e");
            public static Guid DSBrand =  new Guid("8e64cee3-5127-4558-8865-bc5ef2eb088c");
            public static Guid FerrariBrandId = new Guid("a9e87cc5-338a-483a-a1a1-96e787f21ed7");
            public static Guid FiatBrandId = new Guid("16035d4f-d555-453e-bb7c-b7f05e0514c2");
            public static Guid FordBrandId = new Guid("264b0380-1a13-48c9-b204-bcd2eeae1428");
            public static Guid HondaBrandId = new Guid("6a99c551-f9d5-42fd-be39-da133a98f822");
            public static Guid HyundaiBrandId = new Guid("d47655b3-a456-45ee-ae28-65ad1d3d47d1");
            public static Guid InfinitiBrandId = new Guid("328ff0da-484b-448a-846b-907a40dce7c0");
            public static Guid IsuzuBrandId = new Guid("6535ee74-9ebb-4477-8447-025358b8b00e");
            public static Guid JaguarBrandId = new Guid("e68a8475-bb42-4286-8a32-95ac9fa1e94c");
            public static Guid JeepBrandId = new Guid("9c04ac18-84bb-4c0e-81ac-9a6e0b89813f");
            public static Guid KIABrandId = new Guid("0405942f-adee-423c-8857-7901e381af1e");
            public static Guid LadaBrandId = new Guid("caab192c-18fd-4950-b462-b30f52626f96");
            public static Guid LamborghiniBrandId = new Guid("fb839133-38f5-4347-b442-7d21b88487fd");
            public static Guid LanciaBrandId = new Guid("12d53665-2ed6-49d3-9b0f-7fdfdb53bb93");
            public static Guid LandRoverBrandId = new Guid("ddd9110e-d4f8-4854-a19f-adc35e02068c");
            public static Guid LexusBrandId = new Guid("51fc0891-f920-470b-b188-eca099d798b6");
            public static Guid LotusBrandId = new Guid("59d823eb-2326-4472-8b22-dacc812a81df");
            public static Guid MahindraBrandId = new Guid("b47ecb53-95b7-4d49-953a-b8300158c667");
            public static Guid MaseratiBrandId = new Guid("863271c4-5352-45ce-970b-e3bb85f08156");
            public static Guid MazdaBrandId = new Guid("e93d8fa7-4e6e-4d40-9b24-a2cdae10e0b1");
            public static Guid McLarenBrandId = new Guid("49308e35-7016-4d8a-8958-fc1e7052aff5");
            public static Guid MercedesBrandId = new Guid("41094f96-569f-4e30-bc7e-069ad44de42e");
            public static Guid MiniBrandId = new Guid("ed552fbb-842f-472a-8ac2-62ee70fb0649");
            public static Guid MitsubishiBrandId = new Guid("d1291c11-6a3a-48bd-9e4f-1c525239432c");
            public static Guid MorganBrandId = new Guid("9037c033-802a-430a-a706-25240e734795");
            public static Guid NissanBrandId = new Guid("ab8d386c-2116-4fe6-b5d6-bc4b01a0f946");
            public static Guid OpelBrandId = new Guid("e8859245-ccdb-48e4-a512-665a267ad2ce");
            public static Guid PeugeotBrandId = new Guid("0f80e5c2-7ad5-4584-9bff-178f4064df38");
            public static Guid PorscheBrandId = new Guid("1cdb9d43-c361-4ac5-b26d-0d52a2463d14");
            public static Guid RenaultBrandId = new Guid("3e14c502-970d-43dd-a99b-f44139fe59c3");
            public static Guid RollsRoyceBrandId =  new Guid("533bffce-2f57-44b0-a5ef-44650acab7a8");
            public static Guid SeatBrandId = new Guid("3ab9ce82-6b4b-47ea-9454-34217cc14305");
            public static Guid ŠkodaBrandId = new Guid("2776ccc3-334b-4471-bc60-784cdeb22c9b");
            public static Guid SmartBrandId = new Guid("c631dd21-c3fa-4750-90fd-2b54ece988d7");
            public static Guid SsangYongBrandId = new Guid("777989fa-f121-4edb-8c74-745fe05661a2");
            public static Guid SubaruBrandId = new Guid("602df1c2-33cc-4078-9f32-25544e8b6744");
            public static Guid SuzukiBrandId = new Guid("653ce868-ad39-4806-88b5-6e2ad4400177");
            public static Guid TATABrandId = new Guid("6eb4e739-a0ef-4e20-b3e2-69615d4c1529");
            public static Guid TeslaBrandId = new Guid("4b269ab7-f075-4b08-a882-abceaefe19c3");
            public static Guid ToyotaBrandId = new Guid("f05d35c1-fddb-4898-a784-40fee261c6d1");
            public static Guid VolkswagenBrandId = new Guid("ae5843fb-c2bb-4629-a107-c261ef02c85f");
            public static Guid VolvoBrandId = new Guid("8ba36d01-fdf0-47db-9ada-dca07a312678");
        }
    }
}
