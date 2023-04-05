
# Discord Picture Uploader

Utility to easily upload pictures and GIFs to discord resized to emoji dimensions with automatically removed backgrounds.
   

## Features
- Various formats are supported.
- Download ready to use emoji packs directly from the program.
- Always stays on top so that the user doesn't have to repeatedly switch windows.
- Does not need token or any additional installation and all pictures and GIFs are stored locally. 
- Safe and does not break the terms of service of discord as it does not modify the client.
- Automatic color replacer for backgrounds to match the discord color palette and seem transparent.
- Automatic size changer so the pictures and GIFs match native emoji sizes. 
- Easily add GIFs via their links to download them directly.
- Selected image/GIF is placed directly into the clipboard so the user can paste them directly to the chat.



## Usage
- The recommended way of using the program is by copying the the link of the emojis sent from discord and pasting them into the program's text box, after doing so, the emoji will appear in the program. (Applies to both static and animated emojis - WebP and GIF)
- To copy an emoji into your clipboard, all you need to do is click on the desired emoji.

## Showcase
https://user-images.githubusercontent.com/69525619/217301867-cb9f27c1-ef64-42e5-8643-7e8f1512620a.mp4


## Notes/Warnings
- GIF file formats are not supported. To automatically add GIFs through the application, add the link to the textbox at the bottom and click add. A text file that includes the link will be automatically created.
- The links of the animated emojis need to be stored in a text file. This is because that when the GIF is set directly into the clipboard, it loses transparency and only the first frame would be copied. 
- It is advised against downloading emojis directly into the Storage file due to apparent artifacts that appear around the emoji. This is because of the way changing the color of the background to match discord's chat color is handled.
- Changing the name of a WebP image will prevent in from showing in the program. This is because the name of the file is the ID that will be placed in discord's CDN attachement URL. 

___
<a href='https://ko-fi.com/ahmedsherif1' target='_blank'><img height='35' style='border:0px;height:46px;' src='https://az743702.vo.msecnd.net/cdn/kofi3.png?v=0' border='0' alt='Buy Me a Coffee at ko-fi.com' />
