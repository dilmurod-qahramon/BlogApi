﻿using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models;

public abstract class EntityBase
{
    [Required]
    public Guid Id { get; private init; } = Guid.NewGuid();
    public DateTimeOffset Created { get; private set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset LastModified { get; private set; } = DateTimeOffset.UtcNow;
    public void UpdateLastModified()
    {
        LastModified = DateTimeOffset.UtcNow;
    }
}
