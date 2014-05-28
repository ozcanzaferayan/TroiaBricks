[33mcommit 7677678c60df174bc367895ac29d48b2242b0e31[m
Author: Özcan Zafer AYAN <ozcanzaferayan@gmail.com>
Date:   Wed May 28 18:14:43 2014 +0300

    ARM version Released

[1mdiff --git a/TemplateFinal/Bin/ARM/Release/AppManifest.xaml b/TemplateFinal/Bin/ARM/Release/AppManifest.xaml[m
[1mnew file mode 100644[m
[1mindex 0000000..08acd10[m
[1m--- /dev/null[m
[1m+++ b/TemplateFinal/Bin/ARM/Release/AppManifest.xaml[m
[36m@@ -0,0 +1,11 @@[m
[32m+[m[32m﻿<Deployment xmlns="http://schemas.microsoft.com/client/2007/deployment" xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" EntryPointAssembly="TemplateFinal" EntryPointType="TemplateFinal.App" RuntimeVersion="4.7.50308.0">[m
[32m+[m[32m  <Deployment.Parts>[m
[32m+[m[32m    <AssemblyPart x:Name="TemplateFinal" Source="TemplateFinal.dll" />[m
[32m+[m[32m    <AssemblyPart x:Name="MonoGame.Framework" Source="MonoGame.Framework.dll" />[m
[32m+[m[32m    <AssemblyPart x:Name="SharpDX" Source="SharpDX.dll" />[m
[32m+[m[32m    <AssemblyPart x:Name="SharpDX.Direct3D11" Source="SharpDX.Direct3D11.dll" />[m
[32m+[m[32m    <AssemblyPart x:Name="SharpDX.XAudio2" Source="SharpDX.XAudio2.dll" />[m
[32m+[m[32m    <AssemblyPart x:Name="SharpDX.DXGI" Source="SharpDX.DXGI.dll" />[m
[32m+[m[32m    <AssemblyPart x:Name="SharpDX.WP8" Source="SharpDX.WP8.dll" />[m
[32m+[m[32m  </Deployment.Parts>[m
[32m+[m[32m</Deployment>[m
\ No newline at end of file[m
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Assets/ApplicationIcon.png b/TemplateFinal/Bin/ARM/Release/Assets/ApplicationIcon.png[m
[1mnew file mode 100644[m
[1mindex 0000000..7d95d4e[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Assets/ApplicationIcon.png differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileLarge.png b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileLarge.png[m
[1mnew file mode 100644[m
[1mindex 0000000..e0c59ac[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileLarge.png differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileMedium.png b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileMedium.png[m
[1mnew file mode 100644[m
[1mindex 0000000..e93b89d[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileMedium.png differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileSmall.png b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileSmall.png[m
[1mnew file mode 100644[m
[1mindex 0000000..550b1b5[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/FlipCycleTileSmall.png differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Assets/Tiles/IconicTileMediumLarge.png b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/IconicTileMediumLarge.png[m
[1mnew file mode 100644[m
[1mindex 0000000..686e6b5[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/IconicTileMediumLarge.png differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Assets/Tiles/IconicTileSmall.png b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/IconicTileSmall.png[m
[1mnew file mode 100644[m
[1mindex 0000000..d4b5ede[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Assets/Tiles/IconicTileSmall.png differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Content/BluePaddle.xnb b/TemplateFinal/Bin/ARM/Release/Content/BluePaddle.xnb[m
[1mnew file mode 100644[m
[1mindex 0000000..689edfe[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Content/BluePaddle.xnb differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Content/GrayBall.xnb b/TemplateFinal/Bin/ARM/Release/Content/GrayBall.xnb[m
[1mnew file mode 100644[m
[1mindex 0000000..62cf847[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Content/GrayBall.xnb differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Content/RedBrick.xnb b/TemplateFinal/Bin/ARM/Release/Content/RedBrick.xnb[m
[1mnew file mode 100644[m
[1mindex 0000000..292abe2[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Content/RedBrick.xnb differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Content/SplitBall.xnb b/TemplateFinal/Bin/ARM/Release/Content/SplitBall.xnb[m
[1mnew file mode 100644[m
[1mindex 0000000..5c493f7[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Content/SplitBall.xnb differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Content/monster.xnb b/TemplateFinal/Bin/ARM/Release/Content/monster.xnb[m
[1mnew file mode 100644[m
[1mindex 0000000..fb6fc3a[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/Content/monster.xnb differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/MonoGame.Framework.dll b/TemplateFinal/Bin/ARM/Release/MonoGame.Framework.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..ae4b4ec[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/MonoGame.Framework.dll differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/MonoGame.Framework.pdb b/TemplateFinal/Bin/ARM/Release/MonoGame.Framework.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..ece073c[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/MonoGame.Framework.pdb differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/Properties/WMAppManifest.xml b/TemplateFinal/Bin/ARM/Release/Properties/WMAppManifest.xml[m
[1mnew file mode 100644[m
[1mindex 0000000..4a4a8ce[m
[1m--- /dev/null[m
[1m+++ b/TemplateFinal/Bin/ARM/Release/Properties/WMAppManifest.xml[m
[36m@@ -0,0 +1,42 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8"?>[m
[32m+[m[32m<Deployment xmlns="http://schemas.microsoft.com/windowsphone/2012/deployment" AppPlatformVersion="8.0">[m
[32m+[m[32m  <DefaultLanguage xmlns="" code="en-US" />[m
[32m+[m[32m  <App xmlns="" ProductID="{f13744ce-a3b0-426b-8a4a-cf6f482b80cd}" Title="SampleGame" RuntimeType="Silverlight" Version="1.0.0.0" Genre="apps.normal" Author="TemplateFinal author" Description="Sample description" Publisher="TemplateFinal" PublisherID="{0df4bf76-7146-42eb-ba7c-83daa7249a23}">[m
[32m+[m[32m    <IconPath IsRelative="true" IsResource="false">Assets\ApplicationIcon.png</IconPath>[m
[32m+[m[32m    <Capabilities>[m
[32m+[m[32m      <Capability Name="ID_CAP_NETWORKING" />[m
[32m+[m[32m      <Capability Name="ID_CAP_MEDIALIB_AUDIO" />[m
[32m+[m[32m      <Capability Name="ID_CAP_MEDIALIB_PLAYBACK" />[m
[32m+[m[32m      <Capability Name="ID_CAP_SENSORS" />[m
[32m+[m[32m      <Capability Name="ID_CAP_WEBBROWSERCOMPONENT" />[m
[32m+[m[32m    </Capabilities>[m
[32m+[m[32m    <Tasks>[m
[32m+[m[32m      <DefaultTask Name="_default" NavigationPage="GamePage.xaml" />[m
[32m+[m[32m    </Tasks>[m
[32m+[m[32m    <Tokens>[m
[32m+[m[32m      <PrimaryToken TokenID="TemplateFinalToken" TaskName="_default">[m
[32m+[m[32m        <TemplateFlip>[m
[32m+[m[32m          <SmallImageURI IsRelative="true" IsResource="false">Assets\Tiles\FlipCycleTileSmall.png</SmallImageURI>[m
[32m+[m[32m          <Count>0</Count>[m
[32m+[m[32m          <BackgroundImageURI IsRelative="true" IsResource="false">Assets\Tiles\FlipCycleTileMedium.png</BackgroundImageURI>[m
[32m+[m[32m          <Title>SampleGame</Title>[m
[32m+[m[32m          <BackContent></BackContent>[m
[32m+[m[32m          <BackBackgroundImageURI></BackBackgroundImageURI>[m
[32m+[m[32m          <BackTitle></BackTitle>[m
[32m+[m[32m          <DeviceLockImageURI></DeviceLockImageURI>[m
[32m+[m[32m          <HasLarge></HasLarge>[m
[32m+[m[32m        </TemplateFlip>[m
[32m+[m[32m      </PrimaryToken>[m
[32m+[m[32m    </Tokens>[m
[32m+[m[32m    <ActivatableClasses>[m
[32m+[m[32m      <InProcessServer>[m
[32m+[m[32m        <Path>SharpDX.WP8.dll</Path>[m
[32m+[m[32m        <ActivatableClass ActivatableClassId="SharpDX.WP8.Interop" ThreadingModel="both" />[m
[32m+[m[32m      </InProcessServer>[m
[32m+[m[32m    </ActivatableClasses>[m
[32m+[m[32m    <ScreenResolutions>[m
[32m+[m[32m      <ScreenResolution Name="ID_RESOLUTION_WVGA" />[m
[32m+[m[32m    </ScreenResolutions>[m
[32m+[m[32m  </App>[m
[32m+[m[32m</Deployment>[m
[32m+[m[32m<!-- WPSDK Version 8.0.9900 -->[m
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/SharpDX.DXGI.dll b/TemplateFinal/Bin/ARM/Release/SharpDX.DXGI.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..8bd2675[m
Binary files /dev/null and b/TemplateFinal/Bin/ARM/Release/SharpDX.DXGI.dll differ
[1mdiff --git a/TemplateFinal/Bin/ARM/Release/SharpDX.DXGI.xml b/TemplateFinal/Bin/ARM/Release/SharpDX.DXGI.xml[m
[1mnew file mode 100644[m
[1mindex 0000000..df2edef[m
[1m--- /dev/null[m
[1m+++ b/TemplateFinal/Bin/ARM/Release/SharpDX.DXGI.xml[m
[36m@@ -0,0 +1,6048 @@[m
[32m+[m[32m<?xml version="1.0"?>[m
[32m+[m[32m<doc>[m
[32m+[m[32m    <assembly>[m
[32m+[m[32m        <name>SharpDX.DXGI</name>[m
[32m+[m[32m    </assembly>[m
[32m+[m[32m    <members>[m
[32m+[m[32m        <member name="T:SharpDX.DXGI.Adapter">[m
[32m+[m[32m            <summary>[m[41m	[m
[32m+[m[32m            <p>The  <strong><see cref="T:SharpDX.DXGI.Adapter"/></strong> interface represents a display sub-system (including one or more GPU's, DACs and video memory).</p>[m[41m	[m
[32m+[m[32m            </summary>[m[41m	[m
[32m+[m[32m            <remarks>[m[41m	[m
[32m+[m[32m            <p>A display sub-system is often referred to as a video card, however, on some machines the display sub-system is part of the mother board.</p><p>To enumerate the display sub-systems, use <strong><see cref="M:SharpDX.DXGI.Factory.GetAdapter(System.Int32)"/></strong>. To get an interface to the adapter for a particular device, use <strong><see cref="M:SharpDX.DXGI.Device.GetAdapter(SharpDX.DXGI.Adapter@)"/></strong>. To create a software adapter, use <strong><see cref="M:SharpDX.DXGI.Factory.CreateSoftwareAdapter(System.IntPtr)"/></strong>.</p>[m[41m	[m
[32m+[m[32m            </remarks>[m[41m	[m
[32m+[m[32m            <!-- No matching elements were found for the following include tag --><include file=".\..\Documentation\CodeComments.xml" path="/comments/comment[@id='IDXGIAdapter']/*"/>[m[41m	[m
[32m+[m[32m            <msdn-id>bb174523</msdn-id>[m[41m	[m
[32m+[m[32m            <unmanaged>IDXGIAdapter</unmanaged>[m[41m	[m
[32m+[m[32m            <unmanaged-short>IDXGIAdapter</unmanaged-short>[m[41m	[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="T:SharpDX.DXGI.DXGIObject">[m
[32m+[m[32m            <summary>[m[41m	[m
[32m+[m[32m            <p>An <strong><see cref="T:SharpDX.DXGI.DXGIObject"/></strong> interface is a base interface for all DXGI objects; <strong><see cref="T:SharpDX.DXGI.DXGIObject"/></strong> supports associating caller-defined (private data) with an object and retrieval of an interface to the parent object.</p>[m[41m	[m
[32m+[m[32m            </summary>[m[41m	[m
[32m+[m[32m            <remarks>[m[41m	[m
[32m+[m[32m            <p><strong><see cref="T:SharpDX.DXGI.DXGIObject"/></strong> implements base class functionality for several other interfaces: <strong><see cref="T:SharpDX.DXGI.Adapter"/></strong>, <strong><see cref="T:SharpDX.DXGI.Device"/></strong>, <strong><see cref="T:SharpDX.DXGI.Factory"/></strong>, <strong><see cref="T:SharpDX.DXGI.Output"/></strong> </p>[m[41m	[m
[32m+[m[32m            </remarks>[m[41m	[m
[32m+[m[32m            <!-- No matching elements were found for the following include tag --><include file=".\..\Documentation\CodeComments.xml" path="/comments/comment[@id='IDXGIObject']/*"/>[m[41m	[m
[32m+[m[32m            <msdn-id>bb174541</msdn-id>[m[41m	[m
[32m+[m[32m            <unmanaged>IDXGIObject</unmanaged>[m[41m	[m
[32m+[m[32m            <unmanaged-short>IDXGIObject</unmanaged-short>[m[41m	[m
[32m+[m[32m        </member>[m
[32m+[m[32m        <member name="M:SharpDX.DXGI.DXGIObject.GetParent``1">[m
[32m+[m[32m            <summary>[m
[32m+[m[32m            Gets the parent of the object.[m
[32m+[m[32m            </summary>[m
[32m+[m[32m            <typeparam name="T">Type of the parent object</typeparam>