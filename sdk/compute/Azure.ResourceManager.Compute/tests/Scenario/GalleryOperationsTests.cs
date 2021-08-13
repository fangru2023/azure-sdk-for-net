﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Compute.Tests.Helpers;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Tests
{
    public class GalleryOperationsTests : ComputeTestBase
    {
        private ResourceGroup _resourceGroup;

        public GalleryOperationsTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        private async Task<Gallery> CreateGalleryAsync(string name)
        {
            _resourceGroup = await CreateResourceGroupAsync();
            var container = _resourceGroup.GetGalleries();
            var input = ResourceDataHelper.GetBasicGalleryData(DefaultLocation);
            return await container.CreateOrUpdateAsync(name, input);
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            var name = Recording.GenerateAssetName("testGallery_");
            var gallery = await CreateGalleryAsync(name);
            await gallery.DeleteAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task StartDelete()
        {
            var name = Recording.GenerateAssetName("testGallery_");
            var gallery = await CreateGalleryAsync(name);
            var deleteOp = await gallery.StartDeleteAsync();
            await deleteOp.WaitForCompletionResponseAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var name = Recording.GenerateAssetName("testGallery_");
            var gallery = await CreateGalleryAsync(name);
            Gallery gallery2 = await gallery.GetAsync();

            ResourceDataHelper.AssertGallery(gallery.Data, gallery2.Data);
        }

        [TestCase]
        [RecordedTest]
        [Ignore("There is a bug in OperationInternals causing we cannot handle this kind of PATCH LRO right now")]
        public async Task Update()
        {
            var name = Recording.GenerateAssetName("testGallery_");
            var gallery = await CreateGalleryAsync(name);
            var description = "This is a gallery for test";
            var update = new GalleryUpdate()
            {
                Description = description
            };
            Gallery updatedGallery = await gallery.UpdateAsync(update);

            Assert.AreEqual(description, updatedGallery.Data.Description);
        }

        [TestCase]
        [RecordedTest]
        public async Task SetTags()
        {
            var name = Recording.GenerateAssetName("testGallery_");
            var gallery = await CreateGalleryAsync(name);
            var tags = new Dictionary<string, string>()
            {
                { "key", "value" }
            };
            Gallery updatedGallery = await gallery.SetTagsAsync(tags);

            Assert.AreEqual(tags, updatedGallery.Data.Tags);
        }
    }
}
