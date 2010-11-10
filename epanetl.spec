Name: epanetl
Version: 2.0.12.2
Release: 3
Vendor: epanet.de
License: GPL
Summary: Model water distribution piping systems
Group: Productivity/Other
Packager: Steffen Macke <sdteffen@sdteffen.de>
BuildRoot:  %{_tmppath}/%{name}-%{version}-build 
Source: %{name}-%{version}.tar.gz
Url: http://epanet.de
BuildRequires: glibc-devel 

%description
EPANETL models water distribution piping systems (hydraulic analysis).
Localized version of the popular EPANET hydraulic modelling package.

%prep
%setup

%build
./configure --prefix=/usr --libdir=%_libdir
make

%install
rm -rf %{buildroot}
%makeinstall

%clean
rm -rf %{buildroot}

%files
%defattr(-, root, root)
%doc AUTHORS COPYING ChangeLog NEWS README TODO
/usr/bin/epanetl
/usr/share/locale/de/LC_MESSAGES/epanetl.mo
/usr/share/locale/ca/LC_MESSAGES/epanetl.mo
/usr/share/locale/es/LC_MESSAGES/epanetl.mo
/usr/share/locale/pl/LC_MESSAGES/epanetl.mo
%exclude %{_includedir}/toolkit.h
%exclude %{_includedir}/toolkit.h
%exclude %_libdir/libepanetl.so
%exclude %_libdir/libepanetl.so.0
%exclude %_libdir/libepanetl.so.0.0.0
%exclude %_libdir/libepanetl.a
%exclude %_libdir/libepanetl.la

%changelog
* Tue Nov 09 2010 - Steffen Macke <sdteffen@sdteffen.de>
- Updates for openSUSE 11.3
* Fri Jul 18 2008 - Steffen Macke <sdteffen@sdteffen.de>
- Initial RPM build for version 2.0.12

