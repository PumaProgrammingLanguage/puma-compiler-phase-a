﻿// LLVM Compiler for the Puma programming language
//   as defined in the document "The Puma Programming Language Specification"
//   available at https://github.com/ThePumaProgrammingLanguage
//
// Copyright © 2024-2025 by Darryl Anthony Burchfield
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System.Diagnostics;
using static Puma.Parser;

namespace Puma
{
    internal partial class Parser
    {
        /// <summary>
        /// 
        /// </summary>
        public class FileNode : ASTNode
        {
            public SectionNode? FirstNode = null;

            public void AddNodeToTree(SectionNode sectionNode)
            {
                Debug.Assert(sectionNode != null);

                // Add the current node to the tree
                if (FirstNode == null)
                {
                    FirstNode = sectionNode;
                    // Set the previous node
                    sectionNode.PreviousNode = this;
                }
                else
                {
                    // find the last section in the tree
                    SectionNode lastSection = FirstNode;
                    while (lastSection.NextSection != null)
                    {
                        lastSection = lastSection.NextSection;
                    }
                    lastSection.NextSection = sectionNode;
                    // Set the previous node
                    sectionNode.PreviousNode = lastSection;
                }
            }
        }
    }
}