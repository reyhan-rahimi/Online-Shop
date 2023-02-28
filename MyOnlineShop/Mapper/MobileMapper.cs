using MyOnlineShop.Models;
using MyOnlineShop.Models.ViewModel;

namespace MyOnlineShop.Mapper
{
    public static class MobileMapper
    {
        public static Mobile ToDataModel(this MobileViewModel viewModel)
        {
            return new Mobile
            {
                Brand = viewModel.Brand,
                Discribtor=viewModel.Discribtor,
                Garanty=viewModel.Garanty, 
                Sale=viewModel.Sale,
                Review=viewModel.Review,
                BackCamera = viewModel.BackCamera,
                BattreySpecifications = viewModel.BattreySpecifications,
                BluetoothVersion = viewModel.BluetoothVersion,
                CameraAbility = viewModel.CameraAbility,
                Colors = viewModel.Colors,
                CommunicationNetworks = viewModel.CommunicationNetworks,
                CommunicationPortals = viewModel.CommunicationPortals,
                CommunicationTechnology = viewModel.CommunicationTechnology,
                CPUFrequency = viewModel.CPUFrequency,
                DateCreate = viewModel.DateCreate,
                Dimensions = viewModel.Dimensions,
                GraphiteProcessore = viewModel.GraphiteProcessore,
                InternalMemory = viewModel.InternalMemory,
                MemoryCardSupport = viewModel.MemoryCardSupport,
                Model = viewModel.Model,
                NumberOfSimCards = viewModel.NumberOfSimCards,
                OperatingSystem = viewModel.OperatingSystem,
                PictureResolution = viewModel.PictureResolution,
                PixelDensity = viewModel.PixelDensity,
                ProcessorType = viewModel.ProcessorType,
                Ramsize = viewModel.Ramsize,
                Price = viewModel.Price,
                Resulotion = viewModel.Resulotion,
                ScreenTechnology = viewModel.ScreenTechnology,
                ScreenToBodyRatio = viewModel.ScreenToBodyRatio,
                SelfiCamera = viewModel.SelfiCamera,
                SIMcardsDescription = viewModel.SIMcardsDescription,
                size = viewModel.size,
                SpecialFeatures = viewModel.SpecialFeatures,
                Weight = viewModel.Weight,
                Film = viewModel.Film,
                Picture = viewModel?.Picture?.FileName,
                Sensor = viewModel.Sensor,
                Chip = viewModel.Chip,
                CPU = viewModel.CPU,
                FourG = viewModel.FourG,
                ThreeG = viewModel.ThreeG,
                TwoG = viewModel.TwoG
            };
        }
    }
}
