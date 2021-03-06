

using System;

public class TenureDto
{
    public int Id { get; set; }
    public string Description { get; set; }
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
    public string Name { get; set; }
}