﻿using LanguageModel.Tests.TestGeneration;
using LanguageService;
using Xunit;

namespace LanguageModel.Tests.GeneratedTestFiles
{
    class WhileStatement_Generated
    {
        [Fact]
        public void Test(Tester t)
        {
            t.N(SyntaxKind.ChunkNode);
            {
                t.N(SyntaxKind.BlockNode);
                {
                    t.N(SyntaxKind.LocalAssignmentStatementNode);
                    {
                        t.N(SyntaxKind.LocalKeyword);
                        t.N(SyntaxKind.NameList);
                        {
                            t.N(SyntaxKind.Identifier);
                        }
                        t.N(SyntaxKind.AssignmentOperator);
                        t.N(SyntaxKind.ExpList);
                        {
                            t.N(SyntaxKind.SimpleExpression);
                            {
                                t.N(SyntaxKind.Number);
                            }
                        }
                    }
                    t.N(SyntaxKind.WhileStatementNode);
                    {
                        t.N(SyntaxKind.WhileKeyword);
                        t.N(SyntaxKind.SquareBracketVar);
                        {
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                            t.N(SyntaxKind.OpenBracket);
                            t.N(SyntaxKind.NameVar);
                            {
                                t.N(SyntaxKind.Identifier);
                            }
                            t.N(SyntaxKind.CloseBracket);
                        }
                        t.N(SyntaxKind.DoKeyword);
                        t.N(SyntaxKind.BlockNode);
                        {
                            t.N(SyntaxKind.FunctionCallStatementNode);
                            {
                                t.N(SyntaxKind.NameVar);
                                {
                                    t.N(SyntaxKind.Identifier);
                                }
                                t.N(SyntaxKind.ParenArg);
                                {
                                    t.N(SyntaxKind.OpenParen);
                                    t.N(SyntaxKind.ExpList);
                                    {
                                        t.N(SyntaxKind.SquareBracketVar);
                                        {
                                            t.N(SyntaxKind.NameVar);
                                            {
                                                t.N(SyntaxKind.Identifier);
                                            }
                                            t.N(SyntaxKind.OpenBracket);
                                            t.N(SyntaxKind.NameVar);
                                            {
                                                t.N(SyntaxKind.Identifier);
                                            }
                                            t.N(SyntaxKind.CloseBracket);
                                        }
                                    }
                                    t.N(SyntaxKind.CloseParen);
                                }
                            }
                            t.N(SyntaxKind.AssignmentStatementNode);
                            {
                                t.N(SyntaxKind.VarList);
                                {
                                    t.N(SyntaxKind.NameVar);
                                    {
                                        t.N(SyntaxKind.Identifier);
                                    }
                                }
                                t.N(SyntaxKind.AssignmentOperator);
                                t.N(SyntaxKind.ExpList);
                                {
                                    t.N(SyntaxKind.BinaryOperatorExpression);
                                    {
                                        t.N(SyntaxKind.NameVar);
                                        {
                                            t.N(SyntaxKind.Identifier);
                                        }
                                        t.N(SyntaxKind.PlusOperator);
                                        t.N(SyntaxKind.SimpleExpression);
                                        {
                                            t.N(SyntaxKind.Number);
                                        }
                                    }
                                }
                            }
                        }
                        t.N(SyntaxKind.EndKeyword);
                    }
                }
                t.N(SyntaxKind.EndOfFile);
            }

        }
    }
}