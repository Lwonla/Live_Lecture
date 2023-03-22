using System.Collections.Generic;
using System;

namespace WpfApp.Models.Entities
{
    class CaseEntity
    {
        public CaseEntity() // Contructor, initialise
        {
            var _datetime = DateTime.Now;
            Id = Guid.NewGuid();
            Created = _datetime;
            Modified = _datetime;
            StatusTypeId = 1;
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;


        public Guid UserId { get; set; } //ID-relation kan autogenereras
        public int StatusTypeId { get; set; }

        public UserEntity User { get; set; } = null!;
        public StatusTypeEntity StatusType { get; set; } = null!;
        public ICollection<CommentEntity> Comments { get; set; } = new HashSet<CommentEntity>();

    }
}
