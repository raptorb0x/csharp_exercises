#!/bin/bash

ifconfig eth0 down
ifconfig eth0 hw ether 00:80:48:37:20:2d
ifconfig eth0 up
