using System;

namespace EDC_Estate.Models.DB
{
    public partial class EmailTask
    {
        public int Id { get; set; }
        public int ManagementUnitId { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public int? SenderId { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? ActionDeadlineDate { get; set; }
        public DateTime? ActionCompletedDate { get; set; }
        public string RequestComments { get; set; }
        public string ClosingComments { get; set; }
        public string SuggestionsOrActions { get; set; }
        public int DocumentId { get; set; }
        public bool NotifyOnComplete { get; set; }
        public bool Deleted { get; set; }
        public bool IsProtected { get; set; }
        public bool IsHistorical { get; set; }
        public bool IsDefaultValue { get; set; }
        public DateTime Lmdt { get; set; }
        public int Lmuid { get; set; }
        public DateTime? Crdt { get; set; }
        public int? Cruid { get; set; }
        public DateTime? Dldt { get; set; }
        public int? Dluid { get; set; }

        public virtual User Lmu { get; set; }
        public virtual ManagementUnit ManagementUnit { get; set; }
        public virtual User Sender { get; set; }
    }
}
