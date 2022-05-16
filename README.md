# Book Finder
Notes on the Book Finder app for my interview with Sandia National Labs.

## Preparation
I'd never worked with the Google Book API before, so I spent 
time reading about it and experimenting with it, to learn how to
perform a search with the Google Book API. This was done in
a separate, console project.

### Architectual changes
I'm going to create another project to put the Google Book API code into

## The basic app
The basic instrunctions were to prepare an app that allowed a user
to search for books either by author or title. Naturally, other
options could also be done, but for now I'm going to focus upon 
those two

## A Google Book API NuGet Package!
I discovered that NuGet has an API for Google Books! Its called **Google.Apis.Books.v1**
and [can be found here](https://www.nuget.org/packages/Google.Apis.Books.v1).

### Follow-up for the NuGet Google.Apis.Books.v1
After spending a couple of days trying to work with this NuGet package, I've decided
to adandon it. It doesn't seem to work well. My guess is it was written for older versions
of the .NET Framework, whereas I'm using .NET 6.

## The approach I'll follow now
I'll have two pages, one for searching by author, the other 
for searching by title. I'm chosing this approach because at the 
moment I'm not sure how to restrict the search by one and not the 
other, if the user enters both author and title.

## Working on searching by Author
I've begun the work in a separate feature branch. However, I'm created a PR
and merged the feature branch back into `main`. Then deleted the feature branch.
Will need to resume work on this tomorrow.

## Future version

In a later version allowing the user to search both by author
and title would be useful.
