using DnDBagOfHolding.Common.Models.Dtos;
using DnDBagOfHolding.Data.Models;
using Mapster;

namespace DnDBagOfHolding.Data
{
    public class cMappingConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<cDbCharacter, cDtoCharacter>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.CharacterSize, src => src.CharacterSize)
                .Map(dest => dest.StrengthScore, src => src.StrengthScore);

            TypeAdapterConfig<cDbItem, cDtoItem>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.Weight, src => src.Weight)
                .Map(dest => dest.Size, src => src.Size);

            TypeAdapterConfig<cDbContainerType, cDtoContainerType>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.WeightCapacity, src => src.WeightCapacity)
                .Map(dest => dest.ItemCapacity, src => src.ItemCapacity)
                .Map(dest => dest.IsMagical, src => src.IsMagical)
                .Map(dest => dest.Value, src => src.Value);

            TypeAdapterConfig<cDbContainer, cDtoContainer>.NewConfig()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.ContainerTypeId, src => src.ContainerTypeId)
                .Map(dest => dest.CurrentWeight, src => src.CurrentWeight);
        }
    }
}
