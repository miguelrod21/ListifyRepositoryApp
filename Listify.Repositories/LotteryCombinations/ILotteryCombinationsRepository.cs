﻿using Listify.Repositories.LotteryCombinations.Dtos;

namespace Listify.Repositories.LotteryCombinations
{
    public interface ILotteryCombinationsRepository
    {
        List<CombinationDto> GetAll();
    }
}