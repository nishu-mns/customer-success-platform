﻿namespace Promact.CustomerSuccess.Platform.Services.Dtos
{
    public class CreateProjectUpdateDto
    {
        public Guid ProjectId { get; set; }
        public DateTime Date { get; set; }
        public required string Update { get; set; }
    }
}
