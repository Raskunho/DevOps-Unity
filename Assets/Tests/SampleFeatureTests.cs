using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SampleFeatureTests
{
    //// A Test behaves as an ordinary method
    //[Test]
    //public void SampleFeatureTestsSimplePasses()
    //{
    //    // Use the Assert class to test conditions
    //}

    //// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    //// `yield return null;` to skip a frame.
    //[UnityTest]
    //public IEnumerator SampleFeatureTestsWithEnumeratorPasses()
    //{
    //    // Use the Assert class to test conditions.
    //    // Use yield to skip a frame.
    //    yield return null;
    //}



    [SetUp]
    public void SetUp()
    {
        SampleFeature.UniqueStrings?.Clear();
    }


    // Test that we can add a single value
    [Test]
    public void CanAddAValue()
    {
        SampleFeature.TryAddUniqueValue("test");

        Assert.AreEqual(1, SampleFeature.UniqueStrings.Count);
    }

    // Test that we can add many values
    [Test]
    public void CanAddManyValues()
    {
        SampleFeature.TryAddUniqueValue("test");
        SampleFeature.TryAddUniqueValue("test2");

        Assert.AreEqual(2, SampleFeature.UniqueStrings.Count);
    }

    // Test that we cannot add duplicates
    [Test]
    public void CannotAddTheSameValue()
    {
        SampleFeature.TryAddUniqueValue("test");
        SampleFeature.TryAddUniqueValue("test");

        Assert.AreEqual(1, SampleFeature.UniqueStrings.Count);
    }
}
