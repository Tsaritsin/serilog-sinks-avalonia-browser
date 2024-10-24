﻿using Serilog.Parsing;

namespace Serilog.Sinks.Avalonia.Browser.Rendering;

internal static class AlignmentExtensions
{
    public static Alignment Widen(this Alignment alignment,
                                  int amount)
    {
        return new Alignment(alignment.Direction, alignment.Width + amount);
    }
}
