﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Game.Storyboards.Drawables;

namespace osu.Game.Storyboards
{
    public class StoryboardVideo : IStoryboardElement
    {
        public string Path { get; }

        public bool IsDrawable => true;

        public double StartTime { get; }

        public int XOffset { get; }

        public int YOffset { get; }

        public StoryboardVideo(string path, int offset, int xOffset, int yOffset)
        {
            Path = path;
            StartTime = offset;
            XOffset = xOffset;
            YOffset = yOffset;
        }

        public Drawable CreateDrawable() => new DrawableStoryboardVideo(this);
    }
}
