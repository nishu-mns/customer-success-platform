﻿namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class UpdateApprovedTeamDto
    {
        public Guid ProjectId { get; set; }
        public int Phase { get; set; }
        public int NumberOfResources { get; set; }
        public string Role { get; set; }
        public int AvailabilityPercentage { get; set; }
        public int Duration { get; set; }
    }
}
