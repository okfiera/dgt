using Domain.MainBoundedContext.DgtModule.Aggregates.BrandAgg;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.MainBoundedContext.DgtModule.InitialData
{
    public class InitialDataBrands
    {
        public static void Seed(UnitOfWork.MainBCUnitOfWork context)
        {
            var AbarthBrand = new Brand() { Name = "Abarth" }; AbarthBrand.ChangeCurrentIdentity(new Guid("50ed8514-fec6-46cb-b914-34d40e93710b")); context.Brands.AddOrUpdate(AbarthBrand);
            var AlfaRomeoBrand = new Brand() { Name = "Alfa Romeo" }; AlfaRomeoBrand.ChangeCurrentIdentity(new Guid("7dab8ad6-0d8e-4318-861e-df4a9ecd7845")); context.Brands.AddOrUpdate(AlfaRomeoBrand);
            var AlpineBrand = new Brand() { Name = "Alpine" }; AlpineBrand.ChangeCurrentIdentity(new Guid("090cc18f-ff4b-40fa-88b6-5a69453a0567")); context.Brands.AddOrUpdate(AlpineBrand);
            var AstonMartinBrand = new Brand() { Name = "Aston Martin" }; AstonMartinBrand.ChangeCurrentIdentity(new Guid("c54a5b97-8ab3-42bf-bfda-0d4823f86bee")); context.Brands.AddOrUpdate(AstonMartinBrand);
            var AudiBrand = new Brand() { Name = "Audi" }; AudiBrand.ChangeCurrentIdentity(new Guid("64ace552-8947-4e4e-a592-f2a9e1bd119f")); context.Brands.AddOrUpdate(AudiBrand);
            var BentleyBrand = new Brand() { Name = "Bentley" }; BentleyBrand.ChangeCurrentIdentity(new Guid("a994ceff-b8bb-4e30-a5e5-6064e47185eb")); context.Brands.AddOrUpdate(BentleyBrand);
            var BMWBrand = new Brand() { Name = "BMW" }; BMWBrand.ChangeCurrentIdentity(new Guid("fd198954-3df6-467b-8dbc-b0feab956391")); context.Brands.AddOrUpdate(BMWBrand);
            var BugattiBrand = new Brand() { Name = "Bugatti" }; BugattiBrand.ChangeCurrentIdentity(new Guid("e206aeda-3375-485b-847c-ad8c753c6a9e")); context.Brands.AddOrUpdate(BugattiBrand);
            var BYDBrand = new Brand() { Name = "BYD" }; BYDBrand.ChangeCurrentIdentity(new Guid("4189b8d0-5a47-458d-8982-00eca08b7e94")); context.Brands.AddOrUpdate(BYDBrand);
            var CadillacBrand = new Brand() { Name = "Cadillac" }; CadillacBrand.ChangeCurrentIdentity(new Guid("90030b41-9d19-479e-adc6-decb97fe9a31")); context.Brands.AddOrUpdate(CadillacBrand);
            var CaterhamBrand = new Brand() { Name = "Caterham" }; CaterhamBrand.ChangeCurrentIdentity(new Guid("25f1f56c-4832-45d7-a1e1-d82ff4c9c18f")); context.Brands.AddOrUpdate(CaterhamBrand);
            var ChevroletBrand = new Brand() { Name = "Chevrolet" }; ChevroletBrand.ChangeCurrentIdentity(new Guid("f3bdbbc3-e233-48f6-a085-2764106624fd")); context.Brands.AddOrUpdate(ChevroletBrand);
            var CitroënBrand = new Brand() { Name = "Citroën" }; CitroënBrand.ChangeCurrentIdentity(new Guid("a22e5c9c-2bd7-4680-add6-99d19766eaf6")); context.Brands.AddOrUpdate(CitroënBrand);
            var CupraBrand = new Brand() { Name = "Cupra" }; CupraBrand.ChangeCurrentIdentity(new Guid("3e276dab-ff88-4ea4-9428-8ed94d5c3251")); context.Brands.AddOrUpdate(CupraBrand);
            var DaciaBrand = new Brand() { Name = "Dacia" }; DaciaBrand.ChangeCurrentIdentity(new Guid("29bb9b99-3462-4f39-a828-e401a06d762e")); context.Brands.AddOrUpdate(DaciaBrand);
            var DSBrand = new Brand() { Name = "DS" }; DSBrand.ChangeCurrentIdentity(new Guid("8e64cee3-5127-4558-8865-bc5ef2eb088c")); context.Brands.AddOrUpdate(DSBrand);
            var FerrariBrand = new Brand() { Name = "Ferrari" }; FerrariBrand.ChangeCurrentIdentity(new Guid("a9e87cc5-338a-483a-a1a1-96e787f21ed7")); context.Brands.AddOrUpdate(FerrariBrand);
            var FiatBrand = new Brand() { Name = "Fiat" }; FiatBrand.ChangeCurrentIdentity(new Guid("16035d4f-d555-453e-bb7c-b7f05e0514c2")); context.Brands.AddOrUpdate(FiatBrand);
            var FordBrand = new Brand() { Name = "Ford" }; FordBrand.ChangeCurrentIdentity(new Guid("264b0380-1a13-48c9-b204-bcd2eeae1428")); context.Brands.AddOrUpdate(FordBrand);
            var HondaBrand = new Brand() { Name = "Honda" }; HondaBrand.ChangeCurrentIdentity(new Guid("6a99c551-f9d5-42fd-be39-da133a98f822")); context.Brands.AddOrUpdate(HondaBrand);
            var HyundaiBrand = new Brand() { Name = "Hyundai" }; HyundaiBrand.ChangeCurrentIdentity(new Guid("d47655b3-a456-45ee-ae28-65ad1d3d47d1")); context.Brands.AddOrUpdate(HyundaiBrand);
            var InfinitiBrand = new Brand() { Name = "Infiniti" }; InfinitiBrand.ChangeCurrentIdentity(new Guid("328ff0da-484b-448a-846b-907a40dce7c0")); context.Brands.AddOrUpdate(InfinitiBrand);
            var IsuzuBrand = new Brand() { Name = "Isuzu" }; IsuzuBrand.ChangeCurrentIdentity(new Guid("6535ee74-9ebb-4477-8447-025358b8b00e")); context.Brands.AddOrUpdate(IsuzuBrand);
            var JaguarBrand = new Brand() { Name = "Jaguar" }; JaguarBrand.ChangeCurrentIdentity(new Guid("e68a8475-bb42-4286-8a32-95ac9fa1e94c")); context.Brands.AddOrUpdate(JaguarBrand);
            var JeepBrand = new Brand() { Name = "Jeep" }; JeepBrand.ChangeCurrentIdentity(new Guid("9c04ac18-84bb-4c0e-81ac-9a6e0b89813f")); context.Brands.AddOrUpdate(JeepBrand);
            var KIABrand = new Brand() { Name = "KIA" }; KIABrand.ChangeCurrentIdentity(new Guid("0405942f-adee-423c-8857-7901e381af1e")); context.Brands.AddOrUpdate(KIABrand);
            var LadaBrand = new Brand() { Name = "Lada" }; LadaBrand.ChangeCurrentIdentity(new Guid("caab192c-18fd-4950-b462-b30f52626f96")); context.Brands.AddOrUpdate(LadaBrand);
            var LamborghiniBrand = new Brand() { Name = "Lamborghini" }; LamborghiniBrand.ChangeCurrentIdentity(new Guid("fb839133-38f5-4347-b442-7d21b88487fd")); context.Brands.AddOrUpdate(LamborghiniBrand);
            var LanciaBrand = new Brand() { Name = "Lancia" }; LanciaBrand.ChangeCurrentIdentity(new Guid("12d53665-2ed6-49d3-9b0f-7fdfdb53bb93")); context.Brands.AddOrUpdate(LanciaBrand);
            var LandRoverBrand = new Brand() { Name = "Land Rover" }; LandRoverBrand.ChangeCurrentIdentity(new Guid("ddd9110e-d4f8-4854-a19f-adc35e02068c")); context.Brands.AddOrUpdate(LandRoverBrand);
            var LexusBrand = new Brand() { Name = "Lexus" }; LexusBrand.ChangeCurrentIdentity(new Guid("51fc0891-f920-470b-b188-eca099d798b6")); context.Brands.AddOrUpdate(LexusBrand);
            var LotusBrand = new Brand() { Name = "Lotus" }; LotusBrand.ChangeCurrentIdentity(new Guid("59d823eb-2326-4472-8b22-dacc812a81df")); context.Brands.AddOrUpdate(LotusBrand);
            var MahindraBrand = new Brand() { Name = "Mahindra" }; MahindraBrand.ChangeCurrentIdentity(new Guid("b47ecb53-95b7-4d49-953a-b8300158c667")); context.Brands.AddOrUpdate(MahindraBrand);
            var MaseratiBrand = new Brand() { Name = "Maserati" }; MaseratiBrand.ChangeCurrentIdentity(new Guid("863271c4-5352-45ce-970b-e3bb85f08156")); context.Brands.AddOrUpdate(MaseratiBrand);
            var MazdaBrand = new Brand() { Name = "Mazda" }; MazdaBrand.ChangeCurrentIdentity(new Guid("e93d8fa7-4e6e-4d40-9b24-a2cdae10e0b1")); context.Brands.AddOrUpdate(MazdaBrand);
            var McLarenBrand = new Brand() { Name = "McLaren" }; McLarenBrand.ChangeCurrentIdentity(new Guid("49308e35-7016-4d8a-8958-fc1e7052aff5")); context.Brands.AddOrUpdate(McLarenBrand);
            var MercedesBrand = new Brand() { Name = "Mercedes" }; MercedesBrand.ChangeCurrentIdentity(new Guid("41094f96-569f-4e30-bc7e-069ad44de42e")); context.Brands.AddOrUpdate(MercedesBrand);
            var MiniBrand = new Brand() { Name = "Mini" }; MiniBrand.ChangeCurrentIdentity(new Guid("ed552fbb-842f-472a-8ac2-62ee70fb0649")); context.Brands.AddOrUpdate(MiniBrand);
            var MitsubishiBrand = new Brand() { Name = "Mitsubishi" }; MitsubishiBrand.ChangeCurrentIdentity(new Guid("d1291c11-6a3a-48bd-9e4f-1c525239432c")); context.Brands.AddOrUpdate(MitsubishiBrand);
            var MorganBrand = new Brand() { Name = "Morgan" }; MorganBrand.ChangeCurrentIdentity(new Guid("9037c033-802a-430a-a706-25240e734795")); context.Brands.AddOrUpdate(MorganBrand);
            var NissanBrand = new Brand() { Name = "Nissan" }; NissanBrand.ChangeCurrentIdentity(new Guid("ab8d386c-2116-4fe6-b5d6-bc4b01a0f946")); context.Brands.AddOrUpdate(NissanBrand);
            var OpelBrand = new Brand() { Name = "Opel" }; OpelBrand.ChangeCurrentIdentity(new Guid("e8859245-ccdb-48e4-a512-665a267ad2ce")); context.Brands.AddOrUpdate(OpelBrand);
            var PeugeotBrand = new Brand() { Name = "Peugeot" }; PeugeotBrand.ChangeCurrentIdentity(new Guid("0f80e5c2-7ad5-4584-9bff-178f4064df38")); context.Brands.AddOrUpdate(PeugeotBrand);
            var PorscheBrand = new Brand() { Name = "Porsche" }; PorscheBrand.ChangeCurrentIdentity(new Guid("1cdb9d43-c361-4ac5-b26d-0d52a2463d14")); context.Brands.AddOrUpdate(PorscheBrand);
            var RenaultBrand = new Brand() { Name = "Renault" }; RenaultBrand.ChangeCurrentIdentity(new Guid("3e14c502-970d-43dd-a99b-f44139fe59c3")); context.Brands.AddOrUpdate(RenaultBrand);
            var RollsRoyceBrand = new Brand() { Name = "Rolls-Royce" }; RollsRoyceBrand.ChangeCurrentIdentity(new Guid("533bffce-2f57-44b0-a5ef-44650acab7a8")); context.Brands.AddOrUpdate(RollsRoyceBrand);
            var SeatBrand = new Brand() { Name = "Seat" }; SeatBrand.ChangeCurrentIdentity(new Guid("3ab9ce82-6b4b-47ea-9454-34217cc14305")); context.Brands.AddOrUpdate(SeatBrand);
            var ŠkodaBrand = new Brand() { Name = "Škoda" }; ŠkodaBrand.ChangeCurrentIdentity(new Guid("2776ccc3-334b-4471-bc60-784cdeb22c9b")); context.Brands.AddOrUpdate(ŠkodaBrand);
            var SmartBrand = new Brand() { Name = "Smart" }; SmartBrand.ChangeCurrentIdentity(new Guid("c631dd21-c3fa-4750-90fd-2b54ece988d7")); context.Brands.AddOrUpdate(SmartBrand);
            var SsangYongBrand = new Brand() { Name = "SsangYong" }; SsangYongBrand.ChangeCurrentIdentity(new Guid("777989fa-f121-4edb-8c74-745fe05661a2")); context.Brands.AddOrUpdate(SsangYongBrand);
            var SubaruBrand = new Brand() { Name = "Subaru" }; SubaruBrand.ChangeCurrentIdentity(new Guid("602df1c2-33cc-4078-9f32-25544e8b6744")); context.Brands.AddOrUpdate(SubaruBrand);
            var SuzukiBrand = new Brand() { Name = "Suzuki" }; SuzukiBrand.ChangeCurrentIdentity(new Guid("653ce868-ad39-4806-88b5-6e2ad4400177")); context.Brands.AddOrUpdate(SuzukiBrand);
            var TATABrand = new Brand() { Name = "TATA" }; TATABrand.ChangeCurrentIdentity(new Guid("6eb4e739-a0ef-4e20-b3e2-69615d4c1529")); context.Brands.AddOrUpdate(TATABrand);
            var TeslaBrand = new Brand() { Name = "Tesla" }; TeslaBrand.ChangeCurrentIdentity(new Guid("4b269ab7-f075-4b08-a882-abceaefe19c3")); context.Brands.AddOrUpdate(TeslaBrand);
            var ToyotaBrand = new Brand() { Name = "Toyota" }; ToyotaBrand.ChangeCurrentIdentity(new Guid("f05d35c1-fddb-4898-a784-40fee261c6d1")); context.Brands.AddOrUpdate(ToyotaBrand);
            var VolkswagenBrand = new Brand() { Name = "Volkswagen" }; VolkswagenBrand.ChangeCurrentIdentity(new Guid("ae5843fb-c2bb-4629-a107-c261ef02c85f")); context.Brands.AddOrUpdate(VolkswagenBrand);
            var VolvoBrand = new Brand() { Name = "Volvo" }; VolvoBrand.ChangeCurrentIdentity(new Guid("8ba36d01-fdf0-47db-9ada-dca07a312678")); context.Brands.AddOrUpdate(VolvoBrand);
        }
    }
}
