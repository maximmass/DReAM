/*
 * MindTouch Dream - a distributed REST framework 
 * Copyright (C) 2006-2009 MindTouch, Inc.
 * www.mindtouch.com  oss@mindtouch.com
 *
 * For community documentation and downloads visit wiki.developer.mindtouch.com;
 * please review the licensing section.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.IO;
using MindTouch.IO;
using NUnit.Framework;

namespace MindTouch.Dream.Test {
    [TestFixture]
    public class TrimmingStringReaderTests {

        [Test]
        public void Nothing_to_trim() {
            TextReader reader = new TrimmingStringReader("this is plain text");
            string result = reader.ReadToEnd();
            Assert.AreEqual("this is plain text", result);
        }

        [Test]
        public void Trim_from_the_beginning() {
            TextReader reader = new TrimmingStringReader("   this is plain text");
            string result = reader.ReadToEnd();
            Assert.AreEqual("this is plain text", result);
        }

        [Test]
        public void Trim_from_the_end() {
            TextReader reader = new TrimmingStringReader("this is plain text   ");
            string result = reader.ReadToEnd();
            Assert.AreEqual("this is plain text", result);
        }

        [Test]
        public void Trim_both_the_beginning_and_end() {
            TextReader reader = new TrimmingStringReader("   this is plain text   ");
            string result = reader.ReadToEnd();
            Assert.AreEqual("this is plain text", result);
        }
    }
}