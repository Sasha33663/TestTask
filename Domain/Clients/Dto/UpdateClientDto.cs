﻿using Domain.Clients.ValueObjects;
using Domain.Common.ValueObjects;

namespace Domain.Clients.Dto;

public readonly record struct UpdateClientDto(Inn? Inn,
                                               ClientType? Type,
                                               ClientName? Name);