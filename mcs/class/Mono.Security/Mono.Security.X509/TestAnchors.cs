//
// TestAnchors.cs: Trust Anchors for development and debugging
//	include test certificates for Microsoft (root agency) and Mono
//
// Author:
//	Sebastien Pouliot (spouliot@motus.com)
//
// (C) 2003 Motus Technologies Inc. (http://www.motus.com)
//

using System;

namespace Mono.Security.X509 {

	public class TestAnchors : TrustAnchors	{

		static byte[] rootagency = { 
			0x30, 0x82, 0x01, 0xCA, 0x30, 0x82, 0x01, 0x74, 0xA0, 0x03, 0x02, 0x01, 
			0x02, 0x02, 0x10, 0x06, 0x37, 0x6C, 0x00, 0xAA, 0x00, 0x64, 0x8A, 0x11, 
			0xCF, 0xB8, 0xD4, 0xAA, 0x5C, 0x35, 0xF4, 0x30, 0x0D, 0x06, 0x09, 0x2A, 
			0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x04, 0x05, 0x00, 0x30, 0x16, 
			0x31, 0x14, 0x30, 0x12, 0x06, 0x03, 0x55, 0x04, 0x03, 0x13, 0x0B, 0x52, 
			0x6F, 0x6F, 0x74, 0x20, 0x41, 0x67, 0x65, 0x6E, 0x63, 0x79, 0x30, 0x1E, 
			0x17, 0x0D, 0x39, 0x36, 0x30, 0x35, 0x32, 0x38, 0x32, 0x32, 0x30, 0x32, 
			0x35, 0x39, 0x5A, 0x17, 0x0D, 0x33, 0x39, 0x31, 0x32, 0x33, 0x31, 0x32, 
			0x33, 0x35, 0x39, 0x35, 0x39, 0x5A, 0x30, 0x16, 0x31, 0x14, 0x30, 0x12, 
			0x06, 0x03, 0x55, 0x04, 0x03, 0x13, 0x0B, 0x52, 0x6F, 0x6F, 0x74, 0x20, 
			0x41, 0x67, 0x65, 0x6E, 0x63, 0x79, 0x30, 0x5B, 0x30, 0x0D, 0x06, 0x09, 
			0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00, 0x03, 
			0x4A, 0x00, 0x30, 0x47, 0x02, 0x40, 0x81, 0x55, 0x22, 0xB9, 0x8A, 0xA4, 
			0x6F, 0xED, 0xD6, 0xE7, 0xD9, 0x66, 0x0F, 0x55, 0xBC, 0xD7, 0xCD, 0xD5, 
			0xBC, 0x4E, 0x40, 0x02, 0x21, 0xA2, 0xB1, 0xF7, 0x87, 0x30, 0x85, 0x5E, 
			0xD2, 0xF2, 0x44, 0xB9, 0xDC, 0x9B, 0x75, 0xB6, 0xFB, 0x46, 0x5F, 0x42, 
			0xB6, 0x9D, 0x23, 0x36, 0x0B, 0xDE, 0x54, 0x0F, 0xCD, 0xBD, 0x1F, 0x99, 
			0x2A, 0x10, 0x58, 0x11, 0xCB, 0x40, 0xCB, 0xB5, 0xA7, 0x41, 0x02, 0x03, 
			0x01, 0x00, 0x01, 0xA3, 0x81, 0x9E, 0x30, 0x81, 0x9B, 0x30, 0x50, 0x06, 
			0x03, 0x55, 0x04, 0x03, 0x04, 0x49, 0x13, 0x47, 0x46, 0x6F, 0x72, 0x20, 
			0x54, 0x65, 0x73, 0x74, 0x69, 0x6E, 0x67, 0x20, 0x50, 0x75, 0x72, 0x70, 
			0x6F, 0x73, 0x65, 0x73, 0x20, 0x4F, 0x6E, 0x6C, 0x79, 0x20, 0x53, 0x61, 
			0x6D, 0x70, 0x6C, 0x65, 0x20, 0x53, 0x6F, 0x66, 0x74, 0x77, 0x61, 0x72, 
			0x65, 0x20, 0x50, 0x75, 0x62, 0x6C, 0x69, 0x73, 0x68, 0x69, 0x6E, 0x67, 
			0x20, 0x43, 0x72, 0x65, 0x64, 0x65, 0x6E, 0x74, 0x69, 0x61, 0x6C, 0x73, 
			0x20, 0x41, 0x67, 0x65, 0x6E, 0x63, 0x79, 0x30, 0x47, 0x06, 0x03, 0x55, 
			0x1D, 0x01, 0x04, 0x40, 0x30, 0x3E, 0x80, 0x10, 0x12, 0xE4, 0x09, 0x2D, 
			0x06, 0x1D, 0x1D, 0x4F, 0x00, 0x8D, 0x61, 0x21, 0xDC, 0x16, 0x64, 0x63, 
			0xA1, 0x18, 0x30, 0x16, 0x31, 0x14, 0x30, 0x12, 0x06, 0x03, 0x55, 0x04, 
			0x03, 0x13, 0x0B, 0x52, 0x6F, 0x6F, 0x74, 0x20, 0x41, 0x67, 0x65, 0x6E, 
			0x63, 0x79, 0x82, 0x10, 0x06, 0x37, 0x6C, 0x00, 0xAA, 0x00, 0x64, 0x8A, 
			0x11, 0xCF, 0xB8, 0xD4, 0xAA, 0x5C, 0x35, 0xF4, 0x30, 0x0D, 0x06, 0x09, 
			0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x04, 0x05, 0x00, 0x03, 
			0x41, 0x00, 0x2D, 0x2E, 0x3E, 0x7B, 0x89, 0x42, 0x89, 0x3F, 0xA8, 0x21, 
			0x17, 0xFA, 0xF0, 0xF5, 0xC3, 0x95, 0xDB, 0x62, 0x69, 0x5B, 0xC9, 0xDC, 
			0xC1, 0xB3, 0xFA, 0xF0, 0xC4, 0x6F, 0x6F, 0x64, 0x9A, 0xBD, 0xE7, 0x1B, 
			0x25, 0x68, 0x72, 0x83, 0x67, 0xBD, 0x56, 0xB0, 0x8D, 0x01, 0xBD, 0x2A, 
			0xF7, 0xCC, 0x4B, 0xBD, 0x87, 0xA5, 0xBA, 0x87, 0x20, 0x4C, 0x42, 0x11, 
			0x41, 0xAD, 0x10, 0x17, 0x3B, 0x8C };

		static byte[] monoTestRoot = { 
			0x30, 0x82, 0x01, 0xC2, 0x30, 0x82, 0x01, 0x2B, 0xA0, 0x03, 0x02, 0x01, 
			0x02, 0x02, 0x10, 0x28, 0xF4, 0x76, 0x38, 0x91, 0x74, 0x0E, 0x48, 0x85, 
			0xC7, 0x6E, 0x88, 0x4F, 0xE1, 0xB0, 0x69, 0x30, 0x0D, 0x06, 0x09, 0x2A, 
			0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x04, 0x05, 0x00, 0x30, 0x20, 
			0x31, 0x1E, 0x30, 0x1C, 0x06, 0x03, 0x55, 0x04, 0x03, 0x13, 0x15, 0x4D, 
			0x6F, 0x6E, 0x6F, 0x20, 0x54, 0x65, 0x73, 0x74, 0x20, 0x52, 0x6F, 0x6F, 
			0x74, 0x20, 0x41, 0x67, 0x65, 0x6E, 0x63, 0x79, 0x30, 0x1E, 0x17, 0x0D, 
			0x30, 0x33, 0x30, 0x39, 0x30, 0x31, 0x31, 0x35, 0x35, 0x35, 0x34, 0x38, 
			0x5A, 0x17, 0x0D, 0x33, 0x39, 0x31, 0x32, 0x33, 0x31, 0x31, 0x38, 0x35, 
			0x39, 0x35, 0x39, 0x5A, 0x30, 0x20, 0x31, 0x1E, 0x30, 0x1C, 0x06, 0x03, 
			0x55, 0x04, 0x03, 0x13, 0x15, 0x4D, 0x6F, 0x6E, 0x6F, 0x20, 0x54, 0x65, 
			0x73, 0x74, 0x20, 0x52, 0x6F, 0x6F, 0x74, 0x20, 0x41, 0x67, 0x65, 0x6E, 
			0x63, 0x79, 0x30, 0x81, 0x9E, 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 
			0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00, 0x03, 0x81, 0x8C, 0x00, 
			0x30, 0x81, 0x88, 0x02, 0x81, 0x80, 0xBF, 0xFE, 0x27, 0x00, 0xB0, 0x71, 
			0x08, 0x4F, 0xBD, 0x26, 0x01, 0x02, 0xD0, 0xB9, 0xC3, 0x52, 0xF2, 0xA1, 
			0xE9, 0xEF, 0x7A, 0x3F, 0x04, 0xE9, 0x37, 0x84, 0x63, 0xFA, 0xF5, 0xA7, 
			0xA8, 0xA4, 0xFB, 0x20, 0x0A, 0x75, 0x88, 0xAF, 0xC9, 0x8E, 0xEA, 0xAF, 
			0x02, 0x0E, 0x83, 0x43, 0x6B, 0xD3, 0x7E, 0xFD, 0x1D, 0x4E, 0x5A, 0x9F, 
			0x7E, 0x61, 0xC7, 0xE7, 0x53, 0xB2, 0x8A, 0x8A, 0x6B, 0x71, 0x3E, 0x67, 
			0xCF, 0x17, 0x12, 0x4E, 0xC6, 0x5B, 0xFF, 0xD8, 0xDC, 0x1D, 0x27, 0x06, 
			0xD2, 0xCD, 0xFF, 0x15, 0x12, 0x16, 0x9D, 0x77, 0x8B, 0x93, 0xF7, 0xE0, 
			0x9B, 0xB9, 0x92, 0x62, 0x18, 0xD4, 0x68, 0x73, 0x48, 0xD2, 0x6D, 0x7F, 
			0x35, 0x34, 0xE4, 0xB6, 0x2A, 0x62, 0x72, 0x32, 0xB1, 0xA3, 0xBD, 0x61, 
			0x18, 0x88, 0x3D, 0xAA, 0xE7, 0x02, 0x5A, 0x70, 0xEE, 0x9B, 0xE2, 0xAB, 
			0x87, 0xF9, 0x02, 0x03, 0x01, 0x00, 0x01, 0x30, 0x0D, 0x06, 0x09, 0x2A, 
			0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x04, 0x05, 0x00, 0x03, 0x81, 
			0x81, 0x00, 0x8E, 0x08, 0xD7, 0x0F, 0x30, 0xB2, 0xFD, 0x3A, 0x5C, 0x94, 
			0xA9, 0x56, 0xBE, 0x44, 0x77, 0xE3, 0xA3, 0x92, 0xBC, 0xB9, 0xE4, 0x95, 
			0x68, 0xD4, 0xF4, 0xF9, 0x24, 0x4B, 0x2A, 0x79, 0x93, 0x57, 0x7E, 0x84, 
			0x50, 0x3F, 0xA9, 0xC8, 0xDA, 0x9E, 0x08, 0x9C, 0x21, 0xE1, 0x10, 0xFC, 
			0x1C, 0x5C, 0x4B, 0x60, 0x97, 0xBA, 0x55, 0xCB, 0x7C, 0xEA, 0xC3, 0x04, 
			0x2F, 0x55, 0xBB, 0x16, 0x26, 0xCD, 0x87, 0x90, 0x30, 0x7F, 0xE0, 0xCF, 
			0x24, 0x27, 0xB4, 0x3A, 0xD0, 0x9F, 0xC7, 0x55, 0xF8, 0x7C, 0xC9, 0xA0, 
			0x72, 0xE4, 0x06, 0xF1, 0x4A, 0x5B, 0xBB, 0x71, 0x84, 0x8B, 0x76, 0x23, 
			0x65, 0x1F, 0x1B, 0xEA, 0x96, 0x85, 0x13, 0x84, 0x0C, 0x8C, 0xCD, 0xDA, 
			0x3D, 0x1F, 0xEB, 0xA9, 0xA7, 0xDF, 0xE0, 0xD1, 0xDC, 0x93, 0x21, 0x7A, 
			0x10, 0xA7, 0x92, 0x63, 0x5D, 0xAB, 0xA2, 0x13, 0x37, 0xA4 };

		static TestAnchors ()
		{
			// add Microsoft Test Root for people who used MS makecert to create
			// their Authenticode(tm) test certificates
			coll.Add (new X509Certificate (rootagency));

			// add Mono Test Root for people who used Mono makecert to create
			// their Authenticode(tm) test certificates
			coll.Add (new X509Certificate (monoTestRoot));
		}
	}
}
