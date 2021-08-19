﻿using System;
using System.Collections.Generic;

namespace SSWSophieBot.HttpClientAction.Models
{
    public class GetEmployeeModel
    {
        public string OrganisationId { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PersonalEmailAddress { get; set; }
        public string MobilePhone { get; set; }
        public bool InOffice { get; set; }
        public bool IsActive { get; set; }
        public bool IsDuplicateFirstname { get; set; }
        public GetLocationModel DefaultSite { get; set; }
        public List<GetDeviceModel> Devices { get; set; }
        public List<GetAppointmentModel> Appointments { get; set; }
        public List<GetEmployeeProjectModel> Projects { get; set; }
        public GetLastSeenAtSiteModel LastSeenAt { get; set; }
        public List<GetSkillModel> Skills { get; set; }
        public double YtdBillableHours { get; set; }
        public double YtdLeaveHours { get; set; }
        public double YtdTotalWorkHours { get; set; }
        public string AvatarUrl { get; set; }
        public string EmployeePublicProfileUrl { get; set; }
        public string Nickname { get; set; }
        public double BillableRate { get; set; }
        public string BlogUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string SkypeUsername { get; set; }
        public string LinkedInUrl { get; set; }
        public string TwitterUsername { get; set; }
        public string GitHubUrl { get; set; }
        public string YouTubePlayListId { get; set; }
        public DateTime? EstimatedArrivalTime { get; set; }
        public string AboutMeAudioUrl { get; set; }
        public string PublicPhotoAlbumUrl { get; set; }
        public int? EmployeeCategory { get; set; }
        public string Title { get; set; }
    }
}