﻿using Microsoft.Azure.EventGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackageService.Services
{
    interface IEventRepository
    {
        Task SendEventAsync(List<EventGridEvent> eventGridEvent);
    }
}
