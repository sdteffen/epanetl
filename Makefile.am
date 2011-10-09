# not a GNU package. You can remove this line, if
# have all needed files, that a GNU package needs
AUTOMAKE_OPTIONS = foreign 1.4

SUBDIRS = debian installer po src

EXTRA_DIST = config.rpath m4/ChangeLog  Makefile.in epanetl.spec

ACLOCAL_AMFLAGS = -I m4

MINGWDIR = ~/tmp/mingw

gettext-mingw:
	mkdir -p $(MINGWDIR) 
	wget http://ftp.gnome.org/pub/gnome/binaries/win32/dependencies/gettext-runtime_0.18.1.1-2_win32.zip -O $(MINGWDIR)/runtime.zip
	unzip $(MINGWDIR)/runtime.zip -d $(MINGWDIR)
	wget http://ftp.gnome.org/pub/gnome/binaries/win32/dependencies/gettext-runtime-dev_0.18.1.1-2_win32.zip -O $(MINGWDIR)/dev.zip
	unzip $(MINGWDIR)/dev.zip -d $(MINGWDIR)
