﻿using Zamin.Core.RequestResponse.Queries;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetById;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetPagedFilter;
using ZaminTemplate.Core.RequestResponse.FolderName.Queries.GetSelectList;

namespace ZaminTemplate.Core.Contracts.FolderName.Queries;

public interface IAggregateNameQueryRepository
{
    Task<AggregateNameQr?> ExecuteAsync(GetAggregateNameByIdQuery query);

    Task<List<AggregateNameSelectItemQr>> ExecuteAsync(GetAggregateNameSelectListQuery query);

    Task<PagedData<AggregateNameListItemQr>> ExecuteAsync(GetAggregateNamePagedFilterQuery query);
}