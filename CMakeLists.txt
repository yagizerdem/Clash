cmake_minimum_required(VERSION 3.20)

project(Clash)

set( CMAKE_CXX_STANDARD20)
set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_EXTENSIONS OFF)

add_executable(Clash main.c)