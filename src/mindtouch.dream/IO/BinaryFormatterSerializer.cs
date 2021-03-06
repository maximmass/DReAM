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
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MindTouch.IO {

    /// <summary>
    /// Provides an implementation of <see cref="ISerializer"/> capable of serialzing any type marked with the <see cref="SerializableAttribute"/>
    /// attribute.
    /// </summary>
    public class BinaryFormatterSerializer : ISerializer {

        //--- Fields ---
        private readonly BinaryFormatter _serializer = new BinaryFormatter();

        //--- ISerializer Members ---
        T ISerializer.Deserialize<T>(Stream stream) {
            return (T)_serializer.Deserialize(stream);
        }

        void ISerializer.Serialize<T>(Stream stream, T data) {
            _serializer.Serialize(stream, data);
        }
    }
}