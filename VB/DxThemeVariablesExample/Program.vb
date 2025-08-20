' Add services to the container.
' The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
Imports DxThemeVariablesExample.Components ' TODO: Error SkippedTokensTrivia '.'

' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' Configure the HTTP request pipeline.
' TODO: Error SkippedTokensTrivia 'if'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia '{'
' TODO: Error SkippedTokensTrivia ':'
' TODO: Error SkippedTokensTrivia 'true'
' TODO: Error SkippedTokensTrivia ')'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '}'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia ';'
' TODO: Error SkippedTokensTrivia '.'
' TODO: Error SkippedTokensTrivia ';'
 ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
var builder = WebApplication.CreateBuilder(args);

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddRazorCo...' at character 128
''' 
''' 
''' Input:
''' 
// Add services to the container.
builder.Services.AddRazorComponents
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 163
''' 
''' 
''' Input:
''' ()
    .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' AddInteractiveServerComponents();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddDevExpr...' at character 206
''' 
''' 
''' Input:
''' 
builder.Services.AddDevExpressBlazor
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(options ' at character 242
''' 
''' 
''' Input:
''' (options => {

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'options.SizeMode' at character 260
''' 
''' 
''' Input:
'''     options.SizeMode = 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'DevExpress.Blazor.SizeMode....' at character 279
''' 
''' 
''' Input:
''' DevExpress.Blazor.SizeMode.Medium;
});

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'builder.Services.AddMvc' at character 318
''' 
''' 
''' Input:
''' builder.Services.AddMvc
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 341
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert FieldDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitFieldDeclaration(FieldDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' 
var app = builder.Build();

// Configure the HTTP request pipeline.
if 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 417
''' 
''' 
''' Input:
''' (!
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Environment.IsDevelopment' at character 419
''' 
''' 
''' Input:
''' app.Environment.IsDevelopment
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 448
''' 
''' 
''' Input:
''' ()) {

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseExceptionHandler' at character 458
''' 
''' 
''' Input:
'''     app.UseExceptionHandler
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '(' at character 481
''' 
''' 
''' Input:
''' ("/Error", 
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'createScopeForErrors' at character 492
''' 
''' 
''' Input:
''' createScopeForErrors: true);

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHsts' at character 657
''' 
''' 
''' Input:
'''     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 668
''' 
''' 
''' Input:
''' ();
}

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseHttpsRedirection' at character 674
''' 
''' 
''' Input:
''' app.UseHttpsRedirection
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 697
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseStaticFiles' at character 702
''' 
''' 
''' Input:
''' 
app.UseStaticFiles
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 720
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.UseAntiforgery' at character 724
''' 
''' 
''' Input:
''' app.UseAntiforgery
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 742
''' 
''' 
''' Input:
''' ();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.MapRazorComponents<App>' at character 747
''' 
''' 
''' Input:
''' 
app.MapRazorComponents<App>
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 774
''' 
''' 
''' Input:
''' ()
    .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' AddInteractiveServerRenderMode()
    .
'''   ''' Cannot convert ConstructorDeclarationSyntax, System.ArgumentOutOfRangeException: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
''' Parameter name: member
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.GetMemberContext(MemberDeclarationSyntax member)
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
''' AllowAnonymous();

'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in 'app.Run' at character 839
''' 
''' 
''' Input:
''' 
app.Run
'''   ''' Cannot convert IncompleteMemberSyntax, CONVERSION ERROR: Conversion for IncompleteMember not implemented, please report this issue in '()' at character 846
''' 
''' 
''' Input:
''' ();
''' 