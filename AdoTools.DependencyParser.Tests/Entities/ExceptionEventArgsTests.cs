﻿using System;
using NUnit.Framework;
using AdoTools.DependencyParser.Entities;
using AdoTools.Ado.Entities;

namespace AdoTools.DependencyParser.Tests.Entities
{
    [TestFixture]
    public static class ExceptionEventArgsTests
    {
        [Test]
        public static void Constructor_Succeeds()
        {
            var sourceInformation = new SourceInformation(SourceType.TfsGit, "/", false, "test-repo", "develop");
            var exception = new InvalidOperationException("Testing");

            var result = new ExceptionEventArgs(
                sourceInformation,
                exception);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.SourceInformation.Equals(sourceInformation));
            Assert.That(result.Exception, Is.EqualTo(exception));
        }
    }
}