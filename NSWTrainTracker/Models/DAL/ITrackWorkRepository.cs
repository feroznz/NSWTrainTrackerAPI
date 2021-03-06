﻿using System;
using System.Collections.Generic;

namespace NSWTrainTracker.Models.DAL
{
    public interface ITrackWorkRepository
    {
        IEnumerable<TrackWork> Get();
        TrackWork GetById(int id);
        IEnumerable<TrackWork> GetTrackWorksByDate(DateTime date);
    }
}