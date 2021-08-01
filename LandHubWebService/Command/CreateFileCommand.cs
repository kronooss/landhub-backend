﻿using MediatR;

namespace Commands
{
    public class CreateFileCommand : IRequest
    {
        public string Name { get; set; }
        public string OrgId { get; set; }
        public string UploadedBy { get; set; }

        public string Description { get; set; }
        public string Extension { get; set; }
        public double FileSize { get; set; }
        public string Url { get; set; }
    }
}
