   M S B A M L   `   `   `  ����Y  UAqiStar.TextBox, Version=1.0.4758.0, Culture=neutral, PublicKeyToken=a73079b1a9f5484a:.clr-namespace:AqiStar;assembly=AqiStar.TextBoxAqiStar  5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  � IsAsynchronous �� TypeInTargetAssembly    AqiStar.TextBox   AqiStar.LanguageModes   CSharp �� 
ResourceId�� 5      Iwpf9http://schemas.microsoft.com/winfx/2006/xaml/presentation     : 5http://schemas.AqiStar.com/TextBox/LanguageDefinition  5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      6stb.clr-namespace:AqiStar;assembly=AqiStar.TextBox  5      %�+  (��       5      "   # Z )� 6     .  .��5   
   �V�V<RuleSets xmlns="http://schemas.AqiStar.com/TextBox/LanguageDefinition">
                <RuleSet IgnoreCase="false">
                    <Delimiters>&amp;&lt;&gt;~!%^*()-+=|\#/{}[]:;"' ,	.?</Delimiters>

                    <Span Name="PreprocessorDirectives" RuleSet="PreprocessorSet" Foreground="Orange" BreakAtEOL="true">
                        <Begin>#</Begin>
                    </Span>

                    <Span Name="DocLineComment" RuleSet="DocCommentSet" Foreground="Yellow" BreakAtEOL="true" FontName="Tahoma">
                        <Begin Foreground="Yellow">///</Begin>
                    </Span>

                    <Span Name="LineComment" Foreground="Yellow" BreakAtEOL="true" FontName="Tahoma">
                      <Begin>//</Begin>
                    </Span>

                    <Span Name="BlockComment" Foreground="Yellow" BreakAtEOL="false" FontName="Tahoma">
                        <Begin>/*</Begin>
                        <End>*/</End>
                    </Span>

                    <Span Name="String" Foreground="Yellow" BreakAtEOL="true">
                        <Begin>"</Begin>
                        <End>"</End>
                    </Span>

                    <Span Name="MultiLineString" Foreground="Maroon" BreakAtEOL="false">
                        <Begin>@"</Begin>
                        <End>"</End>
                    </Span>

                    <Span Name="Char" Foreground="Maroon" BreakAtEOL="true">
                        <Begin>'</Begin>
                        <End>'</End>
                    </Span>

                    <MarkPrevious Foreground="Orange">(</MarkPrevious>

                    <Keywords Name="AccessKeywords" Foreground="Orange">
                        <Keyword Name="this" />
                        <Keyword Name="base" />
                    </Keywords>

                    <Keywords Name="OperatorKeywords" Foreground="Orange">
                        <Keyword Name="as" />
                        <Keyword Name="is" />
                        <Keyword Name="new" />
                        <Keyword Name="sizeof" />
                        <Keyword Name="typeof" />
                        <Keyword Name="true" />
                        <Keyword Name="false" />
                        <Keyword Name="stackalloc" />
                    </Keywords>

                    <Keywords Name="SelectionStatements" Foreground="Orange">
                        <Keyword Name="else" />
                        <Keyword Name="if" />
                        <Keyword Name="switch" />
                        <Keyword Name="case" />
                        <Keyword Name="default" />
                    </Keywords>

                    <Keywords Name="IterationStatements" Foreground="Orange">
                        <Keyword Name="do" />
                        <Keyword Name="for" />
                        <Keyword Name="foreach" />
                        <Keyword Name="in" />
                        <Keyword Name="while" />
                    </Keywords>

                    <Keywords Name="JumpStatements" Foreground="Orange">
                        <Keyword Name="break" />
                        <Keyword Name="continue" />
                        <Keyword Name="goto" />
                        <Keyword Name="return" />
                    </Keywords>

                    <Keywords Name="ContextKeywords" Foreground="Orange">
                        <Keyword Name="yield" />
                        <Keyword Name="partial" />
                        <Keyword Name="global" />
                        <Keyword Name="where" />
                    </Keywords>

                    <Keywords Name="ExceptionHandlingStatements" Foreground="Orange">
                        <Keyword Name="try" />
                        <Keyword Name="throw" />
                        <Keyword Name="catch" />
                        <Keyword Name="finally" />
                    </Keywords>

                    <Keywords Name="CheckedUncheckedStatements" Foreground="Orange">
                        <Keyword Name="checked" />
                        <Keyword Name="unchecked" />
                    </Keywords>

                    <Keywords Name="UnsafeFixedStatements" Foreground="Orange">
                        <Keyword Name="fixed" />
                        <Keyword Name="unsafe" />
                    </Keywords>

                    <Keywords Name="ValueTypes" Foreground="Orange">
                        <Keyword Name="bool" />
                        <Keyword Name="byte" />
                        <Keyword Name="char" />
                        <Keyword Name="decimal" />
                        <Keyword Name="double" />
                        <Keyword Name="enum" />
                        <Keyword Name="float" />
                        <Keyword Name="int" />
                        <Keyword Name="long" />
                        <Keyword Name="sbyte" />
                        <Keyword Name="short" />
                        <Keyword Name="struct" />
                        <Keyword Name="uint" />
                        <Keyword Name="ushort" />
                        <Keyword Name="ulong" />

                        <Keyword Name="Action" />
                        <Keyword Name="Boolean" />
                        <Keyword Name="Decimal" />
                        <Keyword Name="Double" />
                        <Keyword Name="Int32" />
                        <Keyword Name="Int64" />
                        <Keyword Name="String" />

                    </Keywords>

                    <Keywords Name="ReferenceTypes" Foreground="Orange">
                        <Keyword Name="class" />
                        <Keyword Name="interface" />
                        <Keyword Name="delegate" />
                        <Keyword Name="object" />
                        <Keyword Name="string" />
                    </Keywords>

                    <Keywords Name="Void" Foreground="Orange">
                        <Keyword Name="void" />
                    </Keywords>

                    <Keywords Name="ConversionKeyWords" Foreground="Orange">
                        <Keyword Name="explicit" />
                        <Keyword Name="implicit" />
                        <Keyword Name="operator" />
                    </Keywords>

                    <Keywords Name="MethodParameters" Foreground="Orange">
                        <Keyword Name="params" />
                        <Keyword Name="ref" />
                        <Keyword Name="out" />
                    </Keywords>

                    <Keywords Name="Modifiers" Foreground="Orange">
                        <Keyword Name="abstract" />
                        <Keyword Name="const" />
                        <Keyword Name="event" />
                        <Keyword Name="extern" />
                        <Keyword Name="override" />
                        <Keyword Name="readonly" />
                        <Keyword Name="sealed" />
                        <Keyword Name="static" />
                        <Keyword Name="virtual" />
                        <Keyword Name="volatile" />
                    </Keywords>

                    <Keywords Name="AccessModifiers" Foreground="Orange">
                        <Keyword Name="public" />
                        <Keyword Name="protected" />
                        <Keyword Name="private" />
                        <Keyword Name="internal" />
                    </Keywords>

                    <Keywords Name="NameSpaces" Foreground="Orange">
                        <Keyword Name="namespace" />
                        <Keyword Name="using" />
                    </Keywords>

                    <Keywords Name="LockKeyWord" Foreground="Orange">
                        <Keyword Name="lock" />
                    </Keywords>

                    <Keywords Name="GetSet" Foreground="Orange">
                        <Keyword Name="get" />
                        <Keyword Name="set" />
                        <Keyword Name="add" />
                        <Keyword Name="remove" />
                    </Keywords>

                    <Keywords Name="Literals" Foreground="Orange">
                        <Keyword Name="null" />
                        <Keyword Name="value" />
                    </Keywords>
                </RuleSet>

                <RuleSet Name="DocCommentSet" IgnoreCase="false">
                    <Delimiters>&lt;&gt;~!@%^*()-+=|\#/{}[]:;"' ,	.?</Delimiters>

                    <Span Name="XmlTag" RuleSet="XmlDocSet" Foreground="Yellow" BreakAtEOL="true" FontName="Courier New">
                        <Begin>&lt;</Begin>
                        <End>&gt;</End>
                    </Span>
                </RuleSet>

                <RuleSet Name="PreprocessorSet" IgnoreCase="false">
                    <Delimiters>&amp;&lt;&gt;~!%^*()-+=|\#/{}[]:;"' ,	.?</Delimiters>

                    <Keywords Name="PreprocessorDirectives" Foreground="Orange">
                        <Keyword Name="if" />
                        <Keyword Name="else" />
                        <Keyword Name="elif" />
                        <Keyword Name="endif" />
                        <Keyword Name="define" />
                        <Keyword Name="undef" />
                        <Keyword Name="warning" />
                        <Keyword Name="error" />
                        <Keyword Name="line" />
                        <Keyword Name="region" />
                        <Keyword Name="endregion" />
                        <Keyword Name="pragma" />
                    </Keywords>
                </RuleSet>

                <RuleSet Name="XmlDocSet" IgnoreCase="false">
                    <Delimiters>&lt;&gt;~!@%^*()-+=|\#/{}[]:;"' ,	.?</Delimiters>

                    <Keywords Name="SpecialComment" Foreground="Yellow">
                        <Keyword Name="c" />
                        <Keyword Name="code" />
                        <Keyword Name="example" />
                        <Keyword Name="exception" />
                        <Keyword Name="list" />
                        <Keyword Name="para" />
                        <Keyword Name="param" />
                        <Keyword Name="paramref" />
                        <Keyword Name="permission" />
                        <Keyword Name="remarks" />
                        <Keyword Name="returns" />
                        <Keyword Name="see" />
                        <Keyword Name="seealso" />
                        <Keyword Name="summary" />
                        <Keyword Name="value" />

                        <Keyword Name="type" />
                        <Keyword Name="Name" />
                        <Keyword Name="cref" />
                        <Keyword Name="item" />
                        <Keyword Name="term" />
                        <Keyword Name="description" />
                        <Keyword Name="listheader" />
                    </Keywords>
                </RuleSet>
            </RuleSets>        5     5     